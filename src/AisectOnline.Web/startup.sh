#!/bin/bash

# Configure OpenSSL to accept TLS 1.0/1.1 for on-prem SQL Server compatibility
cat > /tmp/openssl_custom.cnf << 'EOF'
openssl_conf = openssl_init

[openssl_init]
ssl_conf = ssl_sect

[ssl_sect]
system_default = system_default_sect

[system_default_sect]
MinProtocol = TLSv1
CipherString = DEFAULT@SECLEVEL=1
EOF

export OPENSSL_CONF=/tmp/openssl_custom.cnf

cd /home/site/wwwroot
dotnet AisectOnline.Web.dll
