using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using API.DTOs;
using ComponentFactory.Krypton.Toolkit;
using Local;
using Local.Properties;
using MemberDto = Local.DTOs.MemberDto;

namespace DatingApp.App.Forms
{
    public partial class ListsForm : Form
    {
        private readonly IContainer _container;
        private readonly Form1 _form;

        private LikeDto _selectedLikeDto;

        private Image _defaultImage = Resources.avatar;

        public ListsForm(IContainer container, Form1 form)
        {
            _container = container;
            _form = form;
            InitializeComponent();
            LoadData();
        }

        public List<LikeDto> Likes { get; set; }

        private async void LoadData()
        {
            var likes = await GetLikes();
            Likes = likes;
            var shouldBeDisappeared = true;

            if (likes.Count > 0)
            {
                ChangeSliderSelection(likes.First());
                shouldBeDisappeared = false;
            }

            DisappearPanel(shouldBeDisappeared);
        }

        private void DisappearPanel(bool shouldBeDisappeared)
        {
            sliderPanel.Visible = !shouldBeDisappeared;
        }

        private void ChangeSliderSelection(LikeDto likeDto)
        {
            _selectedLikeDto = likeDto;

            sliderPanel.BackgroundImage = string.IsNullOrEmpty(likeDto?.PhotoUrl)
                ? sliderPanel.BackgroundImage = _defaultImage
                : GetImage(likeDto?.PhotoUrl);

            lblKnownAs.Text = likeDto?.KnownAs;
        }

        private Image GetImage(string photoUrl)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photoUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            return img;
        }

        private async Task<List<LikeDto>> GetLikes()
        {
            var predicate = ((string)btnPredicate.SelectedItem) == "Members I like"
                ? "liked"
                : "likedBy";

           var likes = await _container.LikesManager.GetUserLikes(0, predicate);

           return likes;
        }

        private void AddLike(object sender, EventArgs e)
        {
            try
            {
                _container.LikesManager.AddLike(_selectedLikeDto.Username);

            }
            catch (Exception)
            {
            }
        }

        private void EnterChat(object sender, EventArgs e)
        {
            _form.EnterChatWith(_selectedLikeDto.Username);
        }

        private void SliderSlideNext(object sender, EventArgs e)
        {
            if (Likes != null && Likes.Any())
            {
                var oldIndex = Likes.IndexOf(_selectedLikeDto);
                var maxIndex = Likes.Count - 1;
                var newIndex = 0;

                if (oldIndex + 1 <= maxIndex)
                    newIndex = oldIndex + 1;

                var newSelection = Likes[newIndex];
                ChangeSliderSelection(newSelection);
            }
        }

        private void SliderSlideBack(object sender, EventArgs e)
        {
            if (Likes != null && Likes.Any())
            {
                var oldIndex = Likes.IndexOf(_selectedLikeDto);
                var maxIndex = Likes.Count - 1;
                var newIndex = maxIndex;

                if (oldIndex - 1 >= 0)
                    newIndex = oldIndex - 1;

                var newSelection = Likes[newIndex];
                ChangeSliderSelection(newSelection);
            }
        }

        private void btnGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            var btn = (KryptonComboBox)sender;
            LoadData();
        }
    }
}
