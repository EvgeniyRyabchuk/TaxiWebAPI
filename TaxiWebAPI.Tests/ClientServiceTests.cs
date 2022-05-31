using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using TaxiWebAPI.Models.DTO;
using TaxiWebAPI.Services;

namespace TaxiWebAPI.Tests
{
    [TestClass]
    public class ClientServiceTests
    {
        private readonly ClientService _clientService;

        public ClientServiceTests()
        {
            _clientService = new ClientService();
        }

        [TestMethod]
        public void ShouldNotCreateUserWithExistingPhoneNumber()  
        {
            //Init
            AddClientDTO addClientDTO = new AddClientDTO
            {
                PhoneNumber = "+380979726626"
            };

            //Act
            _clientService.RegisterClient(addClientDTO).ConfigureAwait(true);
            Task<ClientShortDTO> userFromRegistrationRepeatTask = _clientService.RegisterClient(addClientDTO);

            ClientShortDTO userFromRegistrationRepeat = userFromRegistrationRepeatTask.Result;

            //Assert
            Assert.IsTrue(userFromRegistrationRepeat.ClientID == 0);
        }
    }
}
