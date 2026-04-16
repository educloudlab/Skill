#!/bin/bash
export OPENSSL_CONF=/home/site/wwwroot/openssl.cnf
cd /home/site/wwwroot
exec dotnet AisectOnline.Web.dll
