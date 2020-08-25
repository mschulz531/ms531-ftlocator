# ms531-ftlocator
San Francisco Food Truck Locator API

The San Francisco food truck locator is a public Web API which provides information on the location of food trucks in the San Francisco area.
Food truck locations vary by day.

The Web API contains one endpoint:  GET https://<myhostname>/api/ftlocator?lat=<lat>&long=<long>[&numResults=<numResults>]

lat and long are required
numResults defaults to 5 if not specified; if specified, min value is 1 and max value is 25

The response contains the details of food trucks that are nearest to the specified geo-coordinates

Expected HTTP status codes:

200 - success
422 - unprocessable entity (lat/long not provided)

The following Azure services are used by this Web API:

Resource Group: rg-ms531ftlocator-wus
Storage Account: stms531ftlocatordata
Virtual Network: vn-ms531ftlocator
Key Vault: kv-ms531ftlocator
Private Endpoint: pe-kv-ms531ftlocator
Private DNS Zone: privatelink.vaultcore.azure.net
Network Interface: pe-kv-ms531ftlocator.nic.a0ca1807-9c0a-4f61-b8f2-7f948b1a69bb

All Azure services are deployed to the US West region which provides the smallest latency from the location of the most likely client requests

TODO for production readiness
    - Add Azure DevOps build pipeline
    - Add Azure DevOps release pipeline for Dev, Staging, and Prod

Future Enhancements:
    - use historical info on food truck locators to predict where a specific food truck may be located
    - add support for food truck locators in additional cities
        - could add param to API which identifies city
        - would have to rethink resource group and resource region locations
    - upgrade Git repo structure
        - add develop branch to source respository 
            - supports master and develop branches to maintain integrity of master branch representation of resources deployed to production
- 
