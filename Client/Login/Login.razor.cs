using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Shared;
using SampleApp.Client.Models;
using System.Net.Http;
using SampleApp.Server.DataBaseModels;
using System.Net.Http.Json;
using Blazored.Toast.Services;

namespace SampleApp.Client.Login
{
    public partial class Login
    {
        [Inject]
        NavigationManager navigation { get; set; }
        LoginModel model = new LoginModel();
        List<Users> users = new();
        [Inject]
        HttpClient httpClient { get; set; }
        [Inject]
        IToastService toastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            users = await httpClient.GetFromJsonAsync<List<Users>>("api/users");
        }

        private void OnSumbit()
        {
            Users user = users.Where(x => x.UserName == model.UserName&&x.Password==model.Password).FirstOrDefault();

            if (user!=null)
            {
                Console.WriteLine(user.Id);
                toastService.ShowSuccess("Login Successfull ... !!!!", "Login");

                navigation.NavigateTo("/counter");
            }
            else
            {
                Console.WriteLine("Login Failed");
                toastService.ShowError("Login Failed ... !!!!", "Login");
            }

            

            model.UserName = "";
            model.Password = "";
        }
    }
}
;