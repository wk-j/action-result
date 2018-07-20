using Microsoft.AspNetCore.Mvc;

namespace ActionResult.Controllers {

    public class Node {
        public string Name { set; get; }
    }

    [Route("api/[controller]/[action]")]
    public class SearchController : ControllerBase {

        [HttpGet]
        public ActionResult<Node> GetNode(int id) {
            if (id == 0) {
                return BadRequest();
            } else {
                return new Node { Name = "N1" };
            }
        }
    }
}