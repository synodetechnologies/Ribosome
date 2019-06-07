# API MODULE

**ApiObjects : create all api dto classes.**
+ Namespace : The namespace for api dto classes.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ EdmxFile : The API model edmx file path.
  + Required? : True, default value :
  
**ApiCommonCommand : create all api common classes.**
+ Namespace : The namespace for api common classes.
  + Required? : True, default value :

**ApiControllerCommonCommand : create all api common controller classes.**
+ Namespace : The namespace for api common controller classes.
  + Required? : True, default value :
+ ApiControllerCommonInterfacesNamespace : The namespace for api common controller interfaces.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :

**ApiControllerCommonInterfacesCommand : create all api common controller interfaces.**
+ Namespace : The namespace for api common controller interfaces.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :

**ApiControllers : create all api controllers classes.**
+ Namespace : The namespace for api controllers classes.
  + Required? : True, default value :
+ ApiServiceInterfacesNamespace : The namespace for api services interfaces.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ ApiControllerExceptionsNamespace : The namespace for api controllers exceptions classes.
  + Required? : True, default value :
+ ApiServiceExceptionsNamespace : The namespace for api services exceptions classes.
  + Required? : True, default value :
+ ApiControllerCommonInterfacesNamespace : The namespace for api common controller interfaces.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ EdmxFile : The API model edmx file path.
  + Required? : True, default value :

**ApiControllerExceptions : create all api controllers exceptions classes for default behavior.**
+ Namespace : The namespace for api controllers exceptions classes.
  + Required? : True, default value :

**ApiServiceInterfaces : create all api services interfaces.**
+ Namespace : The namespace for api services interfaces.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ EdmxFile : The API model edmx file path.
  + Required? : True, default value :

**ApiDummyServices : create all api services dummy classes.**
+ Namespace : The namespace for api dummy services classes.
  + Required? : True, default value :
+ ApiServiceInterfacesNamespace : The namespace for api services interfaces.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ EdmxFile : The API model edmx file path.
  + Required? : True, default value :

**ApiDummyServicesIoc : register all api dummy services classes.**
+ ApiDummyServicesNamespace : The namespace for api dummy services classes.
  + Required? : True, default value :
+ ApiServiceInterfacesNamespace : The namespace for api services interfaces.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ EdmxFile : The API model edmx file path.
  + Required? : True, default value :

**ApiServicesExceptionsCommand : create all api services exceptions classes for default behavior.**
+ Namespace : The namespace for api services exceptions classes.
  + Required? : True, default value :
  
### Additionnal(s) command(s) for CRUD software

**ApiMapperCommand : create needed classes for api mapper.**
+ Namespace : The namespace for api mapper.
  + Required? : True, default value :
  
**DefaultApiMappers : create all mappers.**
+ Namespace : The namespace for api mappers class.
  + Required? : True, default value :
+ ApiBinMapperNamespace : The namespace for api mappers bin class.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :

**DefaultApiServices : create all default api services.**
+ Namespace : The namespace for api default services classes.
  + Required? : True, default value :
+ ApiServiceInterfacesNamespace : The namespace for api services interfaces.
  + Required? : True, default value :
+ DefaultBusinessServiceInterfacesNamespace : The namespace for business services interfaces.
  + Required? : True, default value :
+ ApiServiceExceptionsNamespace : The namespace for api services exceptions classes.
  + Required? : True, default value :
+ ApiCommonNamespace : The namespace for api common classes.
  + Required? : True, default value :
+ BusinessServiceExceptionsNamespace : The namespace for business services exceptions classes.
  + Required? : True, default value :
+ DefaultBusinessCommonNamespace : The namespace for business commons classes.
  + Required? : True, default value :
+ ApiBinMapperNamespace : The namespace for api mappers bin class.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :

**DefaultApiServicesIoc : register api default services classes.**
+ Namespace : The namespace for api default services classes.
  + Required? : True, default value :
+ ApiServiceInterfacesNamespace : The namespace for api services interfaces.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ EdmxFile : The API model edmx file path.
  + Required? : True, default value :
  
# Business MODULE   
  
**BusinessObjects : create all business object classes.**
+ Namespace : The namespace for business object classes.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :
  
### Additionnal(s) command(s) for CRUD software

**DefaultBusinessCommonCommand : create all business common classes.**
+ Namespace : The namespace for default business common classes.
  + Required? : True, default value :

**DefaultBusinessServiceInterfaces : create all business services interfaces.**
+ Namespace : The namespace for business services interfaces.
  + Required? : True, default value :
+ DefaultBusinessCommonNamespace : The namespace for business common classes.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
  
**DefaultBusinessServices : create all business default services classes.**
+ Namespace : The namespace for business services classes.
  + Required? : True, default value :
+ DefaultBusinessServiceInterfacesNamespace : The namespace for business services interfaces.
  + Required? : True, default value :
+ BusinessServiceExceptionsNamespace : The namespace for business services exceptions classes.
  + Required? : True, default value :
+ DataObjectsNamespace : The namespace for dao services interfaces.
  + Required? : True, default value :
+ DefaultDaoServiceInterfacesNamespace : The namespace for dao services interfaces.
  + Required? : True, default value :
+ DefaultBusinessCommonNamespace : The namespace for business common classes.
  + Required? : True, default value :
+ DefaultDataAccessCommonNamespace : The namespace for dao common classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
  
**DefaultBusinessServicesIoc : register business services classes.**
+ Namespace : The namespace for business services interfaces.
  + Required? : True, default value :
+ DefaultBusinessServicesNamespace : The namespace for business services classes.
  + Required? : True, default value :
+ DefaultBusinessServiceInterfacesNamespace : The namespace for business services interfaces.
  + Required? : True, default value :
+ DefaultDaoServiceInterfacesNamespace : The namespace for business services interfaces.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :  

**BusinessServicesExceptions : create all business services exceptions classes for default behavior.**
+ Namespace : The namespace for business services exceptions classes.
  + Required? : True, default value :
  
# MODELER MODULE        

**ModelCreators : create all model creator classes for FluentEntity.**
+ Namespace : The namespace for model creators classes.
  + Required? : True, default value :
+ UseAuditTrail : Activate audit trail ? (default true).
  + Required? : False, default value : true
+ DataObjectsNamespace : The namespace for data object classes.
  + Required? : True, default value :
+ AuditTrailObjectsNamespace : The namespace for audit trail object classes.
  + Required? : False, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :

**ModelerInterfacesCommand : create all modeler interfaces.**
+ Namespace : The namespace for modeler interfaces.
  + Required? : True, default value :

**ModelerFactoriesInterfacesCommand : create all modeler factories interfaces.**
+ Namespace : The namespace for modeler factories interfaces.
  + Required? : True, default value :
  
**ModelerFactoriesCommand : create all modeler factories classes.**
+ Namespace : The namespace for modeler factories classes.
  + Required? : True, default value :
+ ModelerFactoriesInterfacesNamespace : The namespace for modeler factories interfaces.
  + Required? : True, default value :  

**ModelerIncludesCommand : create all modeler include classes.**
+ Namespace : The namespace for modeler include classes.
  + Required? : True, default value :
+ ModelerIncludesDummyNamespace : The namespace for modeler include interfaces.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modeler interfaces.
  + Required? : True, default value :
+ ModelerIncludesInterfacesNamespace : The namespace for modeler includes interfaces.
  + Required? : True, default value :  

**ModelerIncludesInterfacesCommand : create all modeler include interfaces.**
+ Namespace : The namespace for modeler include interfaces.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modeler interfaces.
  + Required? : True, default value :

**ModelerIncludesDummyCommand : create all modeler dummy classes.**
+ Namespace : The namespace for modeler include interfaces.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modeler interfaces.
  + Required? : True, default value :
+ ModelerIncludesInterfacesNamespace : The namespace for modeler includes interfaces.
  + Required? : True, default value :

**ModelersOrderByCommand : create all modeler OrderBy classes.**
+ Namespace : The namespace for OrderBy classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modeler interfaces.
  + Required? : True, default value :
+ ModelersOrderByDummyNamespace : The namespace for modeler dummy classes.
  + Required? : True, default value :

**ModelersOrderByDummyCommand : create all modeler OrderBy Dummy classes.**
+ Namespace : The namespace for OrderBy Dummy classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modeler interfaces.
  + Required? : True, default value :
  
### Additionnal(s) command(s) for CRUD software

# DATA MODULE

**DataObjects : create all data object classes.**
+ Namespace : The namespace for data object classes.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :
  
**DataAccessClassInterfaces : create all dao interfaces.**
+ Namespace : The namespace for dao interfaces.
  + Required? : True, default value :
+ DataObjectsNamespace : The namespace for data object classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :
  
**DataAccessClasses : create all dao classes.**
+ Namespace : The namespace for dao classes.
  + Required? : True, default value :
+ DaoInterfacesNamespace : The namespace for dao interfaces.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
+ DataContextNamespace : The namespace for data context class.
  + Required? : True, default value :
+ DataObjectsNamespace : The namespace for data object classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ ModelerFactoriesInterfacesNamespace : The namespace for modelers factories interfaces.
  + Required? : True, default value :
+ ModelersOrderByNamespace : The namespace for modelers OrderBy classes.
  + Required? : True, default value :
+ ModelerIncludesNamespace : The namespace for modelers includes classes.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :

**DataClassesIoc : create ioc initializer class.**
+ DaoClassesNamespace : The namespace for dao classes.
  + Required? : True, default value :
+ DaoInterfacesNamespace : The namespace for dao interfaces.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :

**DataContext : create ioc initializer class.**
+ Namespace : The namespace for data context class.
  + Required? : True, default value :
+ DataModelCreatorsNamespace : The namespace for model creators classes.
  + Required? : True, default value :
+ UseAuditTrail : Activate audit trail ? (default true).
  + Required? : False, default value : true
+ DataObjectsNamespace : The namespace for data object classes.
  + Required? : True, default value :
+ AuditTrailObjectsNamespace : The namespace for audit trail object classes.
  + Required? : False, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ EdmxFile : The Business model edmx file path.
  + Required? : True, default value :
  
### Additionnal(s) command(s) for CRUD software
                   
**DefaultDataAccessCommonCommand : create all dao common classes.**
+ Namespace : The namespace for default dao common classes.
  + Required? : True, default value :

**DefaultDataAccessServicesInterfaces : create all default dao interfaces.**
+ Namespace : The namespace for dao services interfaces.
  + Required? : True, default value :
+ DefaultDataAccessCommonNamespace : The namespace for dao common classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
  
**DefaultDataAccessClasses : create all default dao classes.**
+ Namespace : The namespace for data services.
  + Required? : True, default value :
+ DefaultDaoServiceInterfacesNamespace : The namespace for dao services interfaces.
  + Required? : True, default value :
+ DataObjectsNamespace : The namespace for data object classes.
  + Required? : True, default value :
+ DaoInterfacesNamespace : The namespace for dao interfaces.
  + Required? : True, default value :
+ DefaultDataAccessCommonNamespace : The namespace for dao common classes.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ ModelersOrderByNamespace : The namespace for modelers OrderBy classes.
  + Required? : True, default value :
+ ModelerIncludesInterfacesNamespace : The namespace for modelers includes interfaces.
  + Required? : True, default value :
+ ModelerIncludesNamespace : The namespace for modelers includes classes.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
  
**DefaultDataClassesIoc : create ioc initializer class for default implementation.**
+ DefaultDaoServiceInterfacesNamespace : The namespace for dao services interfaces.
  + Required? : True, default value :
+ DefaultDaoServicesNamespace : The namespace for dao services.
  + Required? : True, default value :
+ ModelerInterfacesNamespace : The namespace for modelers interfaces.
  + Required? : True, default value :
+ ApiEdmxFile : The API model edmx file path.
  + Required? : True, default value :
+ BusinessEdmxFile : The Business model edmx file path.
  + Required? : True, default value :
+ ApiVersion : The version number of api.
  + Required? : True, default value : 0
+ MappingConfigurationFile : The file path for mapping configuration source file.
  + Required? : True, default value :
+ MappingClassName : The name of mapping class.
  + Required? : True, default value :
+ ApiObjectsNamespace : The namespace for api dto classes.
  + Required? : True, default value :
+ BusinessObjectsNamespace : The namespace for business object classes.
  + Required? : True, default value :
  
  # RIBOSOME MODULE   

**AuditTrailObjects : create audit trail object classes.**
+ Namespace : The namespace for audit trail object classes.
  + Required? : True, default value :  

**LoggerCommand : create all logger classes.**
+ Namespace : The namespace for logger classes.
  + Required? : True, default value :

**JILCommand : create all classes for JIL Formatter.**
+ Namespace : The namespace for JIL Formatter classes.
  + Required? : True, default value :

**ProtobufCommand : create all classes for Protobuf Formatter.**
+ Namespace : The namespace for Protobuf Formatter classes.
  + Required? : True, default value :
  
### Additionnal(s) command(s) for CRUD software
