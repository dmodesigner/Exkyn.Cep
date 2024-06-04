# Importar o módulo WebAdministration
Import-Module WebAdministration

# Definir o nome do pool de aplicativos como parâmetro
$appPoolName = $args[0]

# Obter o objeto do pool de aplicativos
$appPool = Get-WebSite -Name "Default" | Get-WebSiteApplicationPool -Name $appPoolName

# Parar ou iniciar o pool de aplicativos
Start-WebSiteApplicationPool -Name $appPoolName
