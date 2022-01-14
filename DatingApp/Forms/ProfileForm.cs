using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.DTOs;
using Local.Properties;

namespace Local.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly IContainer _container;

        public ProfileForm(IContainer container)
        {
            _container = container;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var username = _container.AccountManager.User.Username;
            var user = await _container.UsersManager.GetUserByUsername(username);

            txtLookingFor.Text = user.LookingFor;
            txtCity.Text = user.City;
            txtCountry.Text = user.Country;
            txtDescription.Text = user.Introduction;
            txtInterests.Text = user.Interests;
            lblAge.Text = user.Age.ToString();
            lblCountry.Text = user.Country;
            lblMemberSince.Text = user.Created.ToString("D");

            detailsUserPicture.Image = string.IsNullOrEmpty(user.PhotoUrl)
                ? detailsUserPicture.Image = Resources.avatar
                : GetImage(user.PhotoUrl);
        }

        private async void SaveChanges(object sender, EventArgs e)
        {
            var memberUpdateDto = new MemberUpdateDto
            {
                Country = txtCountry.Text,
                City = txtCity.Text,
                Interests = txtInterests.Text,
                Introduction = txtDescription.Text,
                LookingFor = txtLookingFor.Text
            };

            await _container.UsersManager.UpdateUser(memberUpdateDto);
            LoadData();
        }

        private Image GetImage(string photoUrl)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photoUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            return img;
        }
    }
}
