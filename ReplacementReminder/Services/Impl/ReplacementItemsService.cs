using AutoMapper;
using ReplacementReminder.Data;
using ReplacementReminder.Exceptions;
using ReplacementReminder.Models;
using ReplacementReminder.Repository.Abstract;
using ReplacementReminder.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReplacementReminder.Services.Impl
{
    public class ReplacementItemsService : IReplacementItemsService
    {
        private readonly IReplacementItemsRepository _replacementItemsRepository;
        private readonly IMapper _mapper;

        public ReplacementItemsService(
            IReplacementItemsRepository replacementItemsRepository,
            IMapper mapper)
        {
            _replacementItemsRepository = replacementItemsRepository;
            _mapper = mapper;
        }

        public List<ReplacementItemModel> FindAll()
        {
            var items = _replacementItemsRepository.FindAll();
            return _mapper.Map<ICollection<ReplacementItem>, List<ReplacementItemModel>>(items);
        }

        public ReplacementItemModel FindById(int id)
        {
            var item = _replacementItemsRepository.FindById(id);
            return _mapper.Map<ReplacementItemModel>(item);
        }

        public bool Create(ReplacementItemModel model)
        {
            var item = _mapper.Map<ReplacementItem>(model);

            return _replacementItemsRepository.Create(item);
        }

        public bool Update(int id, ReplacementItemModel model)
        {
            var item = _replacementItemsRepository.FindById(id);
            if (item == null)
            {
                throw new ItemNotFoundException();
            }

            _mapper.Map(model, item);

           return _replacementItemsRepository.Update(item);
        }

        public bool Delete(int id)
        {
            var item = _replacementItemsRepository.FindById(id);
            if (item == null)
            {
                throw new ItemNotFoundException();
            }

            return _replacementItemsRepository.Delete(item);
        }
    }
}
