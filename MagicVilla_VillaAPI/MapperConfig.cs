using System;
using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI
{
	public class MapperConfig:Profile
	{
		public MapperConfig()
		{
			CreateMap<Villa, VillaDTO>().ReverseMap();
			CreateMap<Villa, VillaCreateDTO>().ReverseMap();
			CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
		}
	}
}

