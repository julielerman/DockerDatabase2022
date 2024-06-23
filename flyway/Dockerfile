FROM flyway/flyway:latest

COPY . /flyway/
COPY bin/*.crt $JAVA_HOME/lib/security/cacerts
# RUN chmod +x /flyway/bin/wait-for-it.sh
RUN $JAVA_HOME/bin/keytool -keystore $JAVA_HOME/lib/security/cacerts -storepass $STORE_PASS -noprompt -trustcacerts -importcert -alias rds-combined-ca-bundle -file rds-combined-ca-bundle.pem

ENTRYPOINT ["flyway"]  