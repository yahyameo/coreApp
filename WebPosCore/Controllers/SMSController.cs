using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebPOSApi.Models;
using WebPOSApi.Models.CampaignVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class SMSController : ControllerBase
    {
        public Task<Response> SendSms(SmsVM model)
        {
           return SmsVM.SendSms(model);
        }
        [HttpPost]
        public Response ApproveSmsRequest(int customerRequestId)
        {
            return SmsVM.ApproveSmsRequest(customerRequestId);
        }
        public Response GetSmsPlan()
        {
            return SmsVM.GetSmsPlan();
        }
        public Response GetSentSms()
        {
            return SmsVM.GetSentSms();
        }
        public Response SendSmsRequest(SmsRequest model)
        {
            return SmsVM.SendSmsRequest(model);
        }
        public Response GetSmsRequestByBranch(int branchId)
        {
            return SmsVM.GetSmsRequestByBranch(branchId);
        }
        public Response GetSMSBalance(int branchId)
        {
            return SmsVM.GetSMSBalance(branchId);
        }
    }
}
