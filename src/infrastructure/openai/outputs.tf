output "resource_group_name" {
  value = azurerm_resource_group.rg.name
}

output "resource_group_id" {
  value = azurerm_resource_group.rg.id
}

output "openai_service_url" {
  value = module.avm-res-cognitiveservices-account.endpoint
}
