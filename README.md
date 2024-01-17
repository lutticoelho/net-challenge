Define steps for a pipeline that will ensure our CI/CD process will guarantee that the project will
retain its functionality and follow our code standards.

CI
 - Run build
 - Run Unit Tests
 - Run Mutation Tests

CD
 - Run build
 - Run Unit Tests
 - Run Mutation Tests
 - Generate Docker image
 - Publish Docker image to registry
 - Update Docker image in stagging environment
 - Execute smoke tests
 - Require at least once approval for an stackholder
 - Update Docker image in production

Please suggest an approach on how we can restrict developers from having access to sensitive
information such as database passwords for production, etc.

- Using user secrets locally and Azure Vault in staging and production environment

