using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Common;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface ICommonService
    {
        Footer GetFooter();
        IEnumerable<Slide> GetSlide();
    }
    public class CommonService : ICommonService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        ISlideRepository _slideRepository;
        public CommonService(IFooterRepository footerRepository, IUnitOfWork unitOfWork, ISlideRepository slideRepository)
        {
            _footerRepository = footerRepository;
            _slideRepository = slideRepository;
            _unitOfWork = unitOfWork;
        }
        public Footer GetFooter()
        {
            return _footerRepository.GetSingleByCondition(x => x.ID == CommonConstants.DefaultFooterId);
        }

        public IEnumerable<Slide> GetSlide()
        {
            return _slideRepository.GetMulti(x => x.Status == true);
        }
    }
}
