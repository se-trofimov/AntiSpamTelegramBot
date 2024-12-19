resource "azurerm_key_vault" "kv" {
  name                        = "kv-assistant-${var.environment_prefix}"
  location                    = var.location
  resource_group_name         = azurerm_resource_group.rg.name
  enabled_for_disk_encryption = true
  tenant_id                   = data.azurerm_client_config.current.tenant_id
  soft_delete_retention_days  = 7
  purge_protection_enabled    = false
  sku_name                    = "standard"
}

## Grant full access for keyvault to owner
resource "azurerm_role_assignment" "keyvault_owner" {
  scope                = azurerm_key_vault.kv.id
  role_definition_name = "Key Vault Administrator"
  principal_id         = var.application_owner_object_id
}
