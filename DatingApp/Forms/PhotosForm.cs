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

namespace DatingApp.App.Forms
{
    public partial class PhotosForm : Form
    {
        private readonly IContainer _container;

        private PhotoDto _selectedPhotoDto;

        private Image _defaultImage = Resources.avatar;

        public PhotosForm(IContainer container)
        {
            _container = container;
            InitializeComponent();
            LoadData();
        }

        public List<PhotoDto> Photos { get; set; }

        private async void LoadData()
        {
            var photos = await GetPhotos();
            Photos = photos;
            var shouldBeDisappeared = true;

            if (photos.Count > 0)
            {
                ChangeSliderSelection(photos.First(x => x.IsMain));
                shouldBeDisappeared = false;
            }

            DisappearPanel(shouldBeDisappeared);
        }

        private void DisappearPanel(bool shouldBeDisappeared)
        {
            sliderPanel.Visible = !shouldBeDisappeared;
        }

        private void ChangeSliderSelection(PhotoDto photoDto)
        {
            _selectedPhotoDto = photoDto;

            sliderPanel.BackgroundImage = string.IsNullOrEmpty(photoDto?.Url)
                ? sliderPanel.BackgroundImage = _defaultImage
                : GetImage(photoDto?.Url);

            btnMainPhoto.Enabled = !_selectedPhotoDto.IsMain;
            btnDeletePhoto.Enabled = !_selectedPhotoDto.IsMain;
        }

        private Image GetImage(string photoUrl)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photoUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            return img;
        }

        private async Task<List<PhotoDto>> GetPhotos()
        {
            var username = _container.AccountManager.User.Username;

            var user = await _container.UsersManager.GetUserByUsername(username);

            return (List<PhotoDto>)user.Photos;
        }

        private void SliderSlideNext(object sender, EventArgs e)
        {
            if (Photos.Any())
            {
                var oldIndex = Photos.IndexOf(_selectedPhotoDto);
                var maxIndex = Photos.Count - 1;
                var newIndex = 0;

                if (oldIndex + 1 <= maxIndex)
                    newIndex = oldIndex + 1;

                var newSelection = Photos[newIndex];
                ChangeSliderSelection(newSelection);
            }
        }

        private void SliderSlideBack(object sender, EventArgs e)
        {
            if (Photos.Any())
            {
                var oldIndex = Photos.IndexOf(_selectedPhotoDto);
                var maxIndex = Photos.Count - 1;
                var newIndex = maxIndex;

                if (oldIndex - 1 >= 0)
                    newIndex = oldIndex - 1;

                var newSelection = Photos[newIndex];
                ChangeSliderSelection(newSelection);
            }
        }

        private async void DeletePhoto(object sender, EventArgs e)
        {
            if (_selectedPhotoDto != null && !_selectedPhotoDto.IsMain)
            {
                await _container.UsersManager.DeletePhoto(_selectedPhotoDto.Id);
                LoadData();
            }
        }

        private async void SetMainPhoto(object sender, EventArgs e)
        {
            if (_selectedPhotoDto != null && !_selectedPhotoDto.IsMain)
            {
                await _container.UsersManager.SetMainPhoto(_selectedPhotoDto.Id);
                LoadData();
            }
        }

        private async void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                await _container.UsersManager.AddPhoto(openFileDialog.FileName);
                LoadData();
            }
        }
    }
}
