using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class BasicController : Controller
    {
        /// <summary>
        /// controller에 쓰이는 method -> action method,   /Basic/Index 경로 요청을 처리한다. 아래는 Index action method 
        /// index에 해당하는 HTML 은 View에서 작업한다 . 다룰수 없고 복잡해지니
        /// View - 현재 Index에 해당하는 View페이지를 응답한다.
        /// Views/Basic/Index or Views/Shared/Index 중 해당페이지가 존재한다면 응답한다.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quest()
        {
            return View();
        }

        public IActionResult Review()
        {
            return View();
        }

        public IActionResult Unit()
        {
            return View();
        }

    }
}
