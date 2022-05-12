using Microsoft.Extensions.Options;
using SendSMSIn.Net6_Core_WithTwilio2.Helpers;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SendSMSIn.Net6_Core_WithTwilio2.Services
{
    public class SMSService : ISMSService
    {
        private readonly TwilioSettings twilio;

        public SMSService(IOptions<TwilioSettings> _twilio)
        {
            twilio = _twilio.Value;
        }

        public MessageResource Send(string mobileNumber, string body)
        {
            TwilioClient.Init(twilio.AccountSID,twilio.AuthToken);
            var result= MessageResource.Create(
                body:body,
                from:new Twilio.Types.PhoneNumber(twilio.TwilioPhoneNumber),
                to:mobileNumber
                );
             return result;
        }
    }
}
