az login
az account set --subscription 3c6595a1-6b82-43ed-8ba8-0f90cc29d3c0

az group create --name NetCoreLiveResourceGroup --location "West Europe"
az group deployment create 
    --name NetCoreExampleDeployment \
    --resource-group NetCoreLiveResourceGroup \
    --template-file webapp-parameters.json \
    --parameters '{"webappName":{"value":"netcorelivedemo"},"servicePlanName":{"value":"netcoresp"}}'

#az group deployment create --name NetCoreExampleDeployment --resource-group NetCoreLiveResourceGroup --template-file webapp-parameters.json --parameters @webapp-parameters.json

#dotnet publish -c Release -o out

#zip application
#"C:\Program Files\7-Zip\7z.exe" a out\deploy.zip out\
