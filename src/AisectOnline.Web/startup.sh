#!/bin/bash

# Configure OpenSSL to accept legacy crypto for on-prem SQL Server compatibility
cat > /tmp/openssl_custom.cnf << 'EOF'
openssl_conf = openssl_init

[openssl_init]
ssl_conf = ssl_sect
providers = provider_sect

[provider_sect]
default = default_sect
legacy = legacy_sect

[default_sect]
activate = 1

[legacy_sect]
activate = 1

[ssl_sect]
system_default = system_default_sect

[system_default_sect]
MinProtocol = TLSv1
CipherString = DEFAULT@SECLEVEL=0
Options = UnsafeLegacyRenegotiation
EOF

export OPENSSL_CONF=/tmp/openssl_custom.cnf

cd /home/site/wwwroot
dotnet AisectOnline.Web.dll
