using AutoMecanica.DTOs;
using AutoMecanica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoMecanica.HttpClients
{
    public class AuthApiUsuario
    {
        private readonly HttpClient _httpClient;


        public AuthApiUsuario(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LoginResultDTO> PostLoginAsync([FromBody]LoginViewModel model)
        {
            var resposta = await _httpClient.PostAsJsonAsync("Login", model);

            return new LoginResultDTO
            {
                Succeeded = resposta.IsSuccessStatusCode,
                Token = await resposta.Content.ReadAsStringAsync(),
     
            };
        }

        public async Task<LoginResultDTO> PostCadastrarAsync(RegistrarViewModel model)
        {
            var resposta = await _httpClient.PostAsJsonAsync("Cadastrar", model);

            return new LoginResultDTO
            {
                Succeeded = resposta.IsSuccessStatusCode,
                Token = await resposta.Content.ReadAsStringAsync()
            };
        }

        public async Task<LoginResultDTO> PostResetarSenhaAsync([FromBody] EsqueciSenhaViewModel model)
        {
            var resposta = await _httpClient.PostAsJsonAsync("RecuperarSenha", model);

            return new LoginResultDTO
            {
                Succeeded = resposta.IsSuccessStatusCode,
                Token = await resposta.Content.ReadAsStringAsync(),

            };
        }

    }


}
