# DevOps

## Questions
- What is DevOps? What problem is it solving?
    - DevOps is a set of practices that combines software development (Dev) and IT operations (Ops). The goal is to shorten the software development lifecycle and provide continuous delivery with high software quality. DevOps emphasizes collaboration, automation, and integration between developers and IT operations teams.
    Problems it Solves:
    - Slow Software Delivery: By automating and streamlining processes, DevOps speeds up the release cycles.
    - Poor Collaboration: Promotes a culture of collaboration between development and operations teams.
    - Inconsistent Environments: Ensures consistent environments from development to production through automation.
    - Unreliable Releases: Improves reliability and stability of releases through continuous testing and integration.

- What is CI (Continuous Integration)?
    - Continuous Integration (CI) is a software development practice where developers frequently merge their code changes into a central repository, typically several times a day. Each integration is automatically built and tested to detect errors as early as possible.

- What is Continuous Delivery?
    - Continuous Delivery (CD) is an extension of Continuous Integration. It ensures that the codebase is always in a deployable state. Code changes are automatically tested and prepared for release to production, but the actual deployment is triggered manually.

- What is Continuous Deployment?
    - Continuous Deployment is a step beyond Continuous Delivery. In this practice, every code change that passes the automated tests is automatically deployed to production, eliminating the need for manual intervention.

- What are benefits of using CI/CD?
    - Faster Time to Market: Speeds up the development and release cycles.
    - Improved Code Quality: Automated testing catches bugs early.
    - Reduced Risk: Smaller, more frequent releases reduce the risk of large-scale failures.
    - Consistent and Reliable Releases: Automation ensures consistency and reduces human error.
    - Enhanced Collaboration: Improves teamwork by integrating development and operations processes.

- What is a YAML file? How do we use it in CI/CD context?
    - YAML (YAML Ain't Markup Language) is a human-readable data serialization standard that is commonly used for configuration files. In the context of CI/CD, YAML files are used to define the pipeline configuration, specifying steps such as building, testing, and deploying code.

- What are some tools available to configure CI/CD pipelines?
    - Jenkins
    - Azure DevOps
    - GitHub Actions

- What is static code analysis?
    - Static Code Analysis is the examination of code without executing it. This analysis is performed to find potential errors, code smells, and security vulnerabilities by evaluating the code against a set of rules or coding standards.

- Why do we use static code analysis tools, such as sonar cloud?
    - Early Detection of Errors: Identifies potential issues before they become problems.
    - Improves Code Quality: Enforces coding standards and best practices.
    - Security: Detects vulnerabilities and ensures compliance with security guidelines.
    - Maintainability: Helps in maintaining clean and readable code.
    - Efficiency: Saves time in code reviews by automating the process of code quality checks.

- What is code coverage, why is it important?
    - Code Coverage measures the percentage of code that is executed by tests. Higher coverage means that more of the codebase is being tested, which generally leads to higher quality and more reliable software.