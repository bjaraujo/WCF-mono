# Mono WCF example

Basic example of WCF Services with Mono. WCF is *Windows Communication Foundation*.

## Run
* Open the `WcfMonoService.sln` file with either MonoDevelop, Xamarin Studio or Visual Studio.
* Build the solution
* Start the solution

It should start two console applications - service and client.

## Structure
* `WcfMonoClient/` Console application - consumes the service.
* `WcfMonoService/` Console application - hosts the WCF service.

## Configuration
Service/client configuration is written in App.config files for both client and service. 
* netNamedPipeBinding
* wsDualHttpBinding
* basicHttpBinding
* netTcpBinding

Notes: 

* Might be necessary to run service as administrator.
* wsDualHttpBinding doesn't seem to be implemented in linux yet, raising NotImplementedException. 

