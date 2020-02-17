using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestDemo
{
    public class SamlingReadOnlyModel
    {
        public SamlingReadOnlyModel()
        {
            SearchResultReadOnly = new List<SearchResultReadOnly>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SearchResultReadOnly> SearchResultReadOnly { get; set; }
    }

    public class SamlingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SearchResultDto> SearchResultDto { get; set; }
    }

   public class SearchResultReadOnly
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public PostItReadOnly PostItReadOnly { get; set; }
    }

    public class SearchResultDto
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public PostItDto postItDto { get; set; }
    }

    public class PostItReadOnly
    {
        public int Id { get; set; }
        public string PostItText { get; set; }
    }

    public class PostItDto
    {
        public int Id { get; set; }
        public string PostItText { get; set; }
    }
}
