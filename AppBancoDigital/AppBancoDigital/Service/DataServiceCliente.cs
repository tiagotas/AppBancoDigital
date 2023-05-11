using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCliente : DataService
    {
        /**
         * Realiza o login do cliente.
         */
        public static async Task<Cliente> LoginAsync(Cliente c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/cliente/entrar");

            return JsonConvert.DeserializeObject<Cliente>(json);
        }

        /**
         * Envia a Model de um Cliente para ser cadastrado no banco.
         */
        public static async Task<Cliente> SaveAsync(Cliente c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/cliente/salvar");

            return JsonConvert.DeserializeObject<Cliente>(json);
        }
    }
}
