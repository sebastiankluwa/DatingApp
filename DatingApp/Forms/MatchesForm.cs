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
using Local;
using Local.DTOs;
using Local.Properties;

namespace DatingApp.App.Forms
{
    public partial class MatchesForm : Form
    {
        private readonly IContainer _container;
        private readonly Form1 _form;

        private MemberDto _selectedMemberDto;

        private Image _defaultImage = Resources.avatar;

        public MatchesForm(IContainer container, Form1 form)
        {
            _container = container;
            _form = form;
            InitializeComponent();
            LoadData();
        }

        public List<MemberDto> Matches { get; set; }

        private async void LoadData()
        {
            var users = await GetUsers();
            Matches = users;
            ChangeSliderSelection(users?.First());
        }

        private void ChangeSliderSelection(MemberDto memberDto)
        {
            _selectedMemberDto = memberDto;

            sliderPanel.BackgroundImage = string.IsNullOrEmpty(memberDto.PhotoUrl)
                ? sliderPanel.BackgroundImage = _defaultImage
                : GetImage(memberDto.PhotoUrl);

            lblKnownAs.Text = memberDto.KnownAs;
        }

        private Image GetImage(string photoUrl)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photoUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            return img;
        }

        private async Task<List<MemberDto>> GetUsers(string gender = "female", int maxAge = 99, int minAge = 18)
        {
            var userParams = new UserParams()
            {
                Gender = gender,
                MaxAge = maxAge,
                MinAge = minAge
            };

           var users = await _container.UsersManager.GetUsers(userParams);

           return users;
        }

        private void AddLike(object sender, EventArgs e)
        {
            try
            {
                _container.LikesManager.AddLike(_selectedMemberDto.Username);

            }
            catch (Exception)
            {
            }
        }

        private void EnterChat(object sender, EventArgs e)
        {
            _form.EnterChatWith(_selectedMemberDto.Username);
        }

        private async void ApplyFilters(object sender, EventArgs e)
        {
            var userParams = new UserParams()
            {
                Gender = (string)btnGender.SelectedItem,
                MaxAge = (int)txtAgeTo.Value,
                MinAge = (int)txtAgeFrom.Value
            };

            Matches = await _container.UsersManager.GetUsers(userParams);
            ChangeSliderSelection(Matches?.FirstOrDefault());
        }

        private void SliderSlideNext(object sender, EventArgs e)
        {
            var oldIndex = Matches.IndexOf(_selectedMemberDto);
            var maxIndex = Matches.Count - 1;
            var newIndex = 0;

            if (oldIndex + 1 <= maxIndex)
                newIndex = oldIndex + 1;

            var newSelection = Matches[newIndex];
            ChangeSliderSelection(newSelection);
        }

        private void SliderSlideBack(object sender, EventArgs e)
        {
            var oldIndex = Matches.IndexOf(_selectedMemberDto);
            var maxIndex = Matches.Count - 1;
            var newIndex = maxIndex;

            if (oldIndex - 1 >= 0)
                newIndex = oldIndex - 1;

            var newSelection = Matches[newIndex];
            ChangeSliderSelection(newSelection);
        }
    }
}
