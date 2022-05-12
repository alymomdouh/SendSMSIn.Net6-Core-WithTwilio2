using Twilio.Rest.Api.V2010.Account;

namespace SendSMSIn.Net6_Core_WithTwilio2.Services
{
    public interface ISMSService
    {
        MessageResource Send(string mobileNumber ,string body);
    }
}
