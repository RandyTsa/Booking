using AutoMapper;
using FastCRUD.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FastCRUD
{
		public static class AutoMapperHelper
		{
			public static Mapper MapperObj { get; set; }
		}
		public class MvcApplication : System.Web.HttpApplication
		{
			protected void Application_Start()
			{
				// �o�̭n�[�W�o��, �~�|�� AutoMapper ������ MappingProfile ���O
				var config = new MapperConfiguration(cfg =>
				{
					// cfg.CreateMap<Category, CategoryDto>(); //�p�G�ݭn�@�ӭӹ���, �N�o�˼g
					cfg.AddProfile<MappingProfile>();
				});
				AutoMapperHelper.MapperObj = new Mapper(config);

				AreaRegistration.RegisterAllAreas();
				FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
				RouteConfig.RegisterRoutes(RouteTable.Routes);
				BundleConfig.RegisterBundles(BundleTable.Bundles);
			}
		}
	}
