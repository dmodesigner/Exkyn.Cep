# Importar o módulo WebAdministration
Import-Module WebAdministration

# Definir o nome do pool de aplicativos como parâmetro
$appPoolName = $args[0]

# Definir a ação (opcional)
$action = "Stop"

# Obter o objeto do pool de aplicativos
$appPool = Get-WebSite -Name "Default" | Get-WebSiteApplicationPool -Name $appPoolName

# Parar ou iniciar o pool de aplicativos
Stop-WebSiteApplicationPool -Name $appPoolName
