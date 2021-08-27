using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using SampleApp.Client.Models;
using SampleApp.Server.DataBaseModels;

namespace SampleApp.Client.Signup
{
    public partial class Signup
    {
        private SignupModel signupModel = new();
        [Inject]
        HttpClient httpClient { get; set; }
        [Inject]
        NavigationManager navigation { get; set; }
        [Inject]
        IToastService toastService { get; set; }

        private async Task SubmitReg()
        {
            Users users = new Users();

            users.UserName = signupModel.UserName;
            users.EmailAdress = signupModel.Email;
            users.Password = signupModel.Password;


            HttpResponseMessage message = await httpClient.PostAsJsonAsync("api/users", users);

            if (message.StatusCode==System.Net.HttpStatusCode.Created)
            {
                toastService.ShowInfo("Created Successfully ... !!!", "Registration");
                navigation.NavigateTo("/");

            }
            else
            {
                toastService.ShowWarning("Created Failed ... !!!", "Registration");

                Console.WriteLine("Failed");
            }

        }

    }
}
