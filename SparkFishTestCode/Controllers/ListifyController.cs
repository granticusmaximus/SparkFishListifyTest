
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SparkFishTestCode.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ListifyController : Controller
    {
        // GET: api/listify
        [HttpGet]
        public string Get()
        {
            return "Please use the following routing: 'listify/rangebegin/rangeend/index'";
        }

        // GET: api/listify/10/100/10
        [HttpGet("{r_start}/{r_end}/{r_index}", Name = "Get")]
        public ActionResult Get(int r_start, int r_end, int r_index)
        {
            return new JsonResult(new { indexvalue = new Listify(r_start, r_end)[r_index] });
        }

    }

    class Listify : IList
    {
        private int r_begin = 0;
        private int r_end = 0;

        public IEnumerable<int> getRange(int x, int y)
        {
            return Enumerable.Range(x, y);
        }

        public Listify(int x, int y)
        {
            r_begin = x;
            r_end = y;
        }

        public object this[int index]
        {
            get
            {
                return getRange(r_begin, r_end).ElementAt(index);
            }
            set
            {

            }
        }
        #region Unused IList members

        private object[] _contents = new object[8];
        private int _count;


        public int Add(object value)
        {
            return 0;
        }

        public void Clear()
        {
        }

        public bool Contains(object value)
        {
            return false;
        }

        public int IndexOf(object value)
        {
            return -1;
        }

        public void Insert(int index, object value)
        {
        }

        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Remove(object value)
        {
        }

        public void RemoveAt(int index)
        {
        }


        // ICollection members.

        public void CopyTo(Array array, int index)
        {
        }

        public int Count
        {
            get
            {
                return 0;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        // Return the current instance since the underlying store is not
        // publicly available.
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }

        // IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            // Refer to the IEnumerator documentation for an example of
            // implementing an enumerator.
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        public void PrintContents()
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }
        #endregion
    }

