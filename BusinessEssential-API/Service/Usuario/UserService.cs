using AutoMapper;
using Domain.Dtos.Usuario;
using Domain.Entidades.Usuarios;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Usuario
{
    public class UserService : IUsersService
    {
        private IATRepository<UserEntity> _repository;
        private ILoginRepository _chck;
        private readonly IMapper _mapper;
        public UserService(IATRepository<UserEntity> repository,ILoginRepository chck,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _chck = chck;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }
        public async Task<UserDto> Get(int id)
        {
            try
            {
                var resultado = await _repository.SelectAsync(id);
                //return new UserDto();
               return _mapper.Map<UserDto>(resultado) ?? new UserDto();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<UserDto>> GetEntity(UserDto User)
        {
            var map = _mapper.Map<UserEntity>(User);
            var resultado = await _repository.SelectEntity(map);
            var result =  _mapper.Map<IEnumerable<UserDto>>(resultado);
            return result;
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var resultado = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDto>>(resultado);
        }

        public async Task<UserEntity> Post(UserDto user)
        {            
            var ck = await _chck.FindByLogin(user.Usuario);
            if (ck.Usuario.ToLower() == user.Usuario.ToLower())
            {
                throw new Exception(message: "Usuario já existe na base de dados");
            }
            else 
            {
                var resultado = _mapper.Map<UserEntity>(user);
                return await _repository.InsertAsync(resultado);
            }

            
        }

        public async Task<UserDto> Put(UserDto user)
        {
            var map = _mapper.Map<UserEntity>(user);
            var resultado = await _repository.UpdateAsync(map);
            var result =  _mapper.Map<UserDto>(resultado);
            return result;
        }
    }
}
