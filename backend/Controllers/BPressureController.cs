using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BPressureController : Controller
    {
        private BPressureContext _context;

        public BPressureController(BPressureContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<BPressure>> Get()
        {
            return _context.BPressures.ToList();
        }
        ~BPressureController()
        {
            _context.Dispose();
        }

        /*[Route("api/[controller]")]
        public IEnumerable<BPressure> GetAll()
        {
            return _context.BPressures.ToList();
            /* return new List<BPressure> {
                new BPressure {
                    PressureId = 1,
                    Systolic = "OI ss",
                    Dyastolic = "FJD",
                    MeanAraterial = "FSDCSD",
                    Pressure = "sdsa dgff",
                    SleepStatus = "si ASU",
                    DyastolicEndpoint = "dlai f"
                },
                new BPressure {
                    PressureId = 2,
                    Systolic = "f OI ss",
                    Dyastolic = "FJdfhD",
                    MeanAraterial = "fdhfFSDCSD",
                    Pressure = "sdfgdsa dgff",
                    SleepStatus = "si ASUfgd",
                    DyastolicEndpoint = "dlai fdfgd"
                }
            }; */
        //}
    }
}
