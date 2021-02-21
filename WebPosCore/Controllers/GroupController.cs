using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebPOSApi.Models.GroupVM;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public dynamic GroupList(int branchId)
        {
            return GroupVM.GroupList(branchId);
        }

        public dynamic GetGroups(int branchId)
        {
            return GroupVM.GetGroups(branchId);
        }

        [HttpPost]
        public dynamic AddGroup(dynamic group)
        {
            return GroupVM.AddGroup(group);
        }

        [HttpPost]
        public dynamic UpdateGroup(dynamic group)
        {
            return GroupVM.UpdateGroup(group);
        }

        [HttpPost]
        public dynamic DeleteGroup(dynamic group)
        {
            return GroupVM.DeleteGroup(group);
        }
    }
}
