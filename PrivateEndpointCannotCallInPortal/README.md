---
description: This template provisions a Function app which has a private endpoint and an http trigger, point is you cannot call http trigger in portal due to missing CORS
page_type: sample
products:
- azure
- azure-resource-manager
urlFragment: PrivateEndpointCannotCallInPortal
languages:
- json
- bicep
---
# Provision a function app on a dedicated plan with a private endpoint so you cannot call the function in portal. Note you will need need to add DNS to your local machine for the PE once configured (or wait until engineer suggests to update DNS, they will still need to fix CORS as well)


[![Deploy To Azure](https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fandrew-manca%2FNewHireScenarios%2Fmain%2FPrivateEndpointCannotCallInPortal%2Fdeploy.json)
