set dist_folder=packages-dist
set version=0.9.4
rem nuget push .\%dist_folder%\SlimMessageBus.0.9.8.*.nupkg -Source %nuget_source%
rem nuget push .\%dist_folder%\SlimMessageBus.Host.0.9.8.*.nupkg -Source %nuget_source%
nuget push .\%dist_folder%\SlimMessageBus.Host.Kafka.0.9.9.*.nupkg -Source %nuget_source%
rem nuget push .\%dist_folder%\SlimMessageBus.Host.ServiceLocator.0.9.6.*.nupkg -Source %nuget_source%
rem nuget push .\%dist_folder%\SlimMessageBus.Host.Serialization.Json.0.9.6.*.nupkg -Source %nuget_source%


