using AppName.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Services
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public class JbeServiceGenerique
    {

        public async Task<T> PostSharp<T>(object param, string url) where T:new()
        {
            IRestResponse<T> response;

            try
            {

                var connexion = Constants.ApiUrl + url;

                var client = new RestSharp.RestClient(connexion);

                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.RequestFormat = DataFormat.Json;
                request.AddBody(param);

                response = await client.ExecutePostTaskAsync<T>(request);
                await Task.Delay(4000);
            }catch(Exception ex)
            {
                throw ex;
            }

            return response.Data;
        }

    }
}
