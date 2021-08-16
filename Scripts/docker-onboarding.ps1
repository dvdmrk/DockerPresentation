# A simple setup script for windows machines

# Required
choco install docker-desktop -y --force

# Recomended
choco install nodejs -y --force # Not required - required on the container
# choco install nvm -y --force # Recomended Alternative
choco install dotnetcore-sdk -y --force # Not required - required on the container
choco install visualstudiocode -y --force # Any IDE will work
choco install git -y --force # VCS CLI for cloning Demo Repo

# Optional
choco install ssms -y --force # For SQL
choco install heidisql -y --force # For PostgreSQL
choco install mysql.workbench -y --force # For MySQL



