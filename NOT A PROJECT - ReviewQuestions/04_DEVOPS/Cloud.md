# Cloud

## Questions
- What is Cloud Computing?
    - Cloud computing refers to the delivery of computing services—including servers, storage, databases, networking, software, and analytics—over the internet (“the cloud”). These services enable users to access and store data and applications on remote servers rather than on local devices, providing flexibility, scalability, and cost-efficiency.

- What are benefits of cloud computing?
    - Cost Efficiency: Eliminates the capital expense of buying hardware and software.
    - Scalability: Easily scale up or down based on demand.
    - Performance: Offers high performance and reduced latency due to distributed data centers.
    - Security: Provides robust security measures, often more advanced than those an individual company can achieve.
    - Disaster Recovery: Simplifies data backup and disaster recovery.
    - Mobility: Access resources from anywhere with an internet connection.
    - Collaboration: Enhances collaboration by allowing multiple users to access and work on data simultaneously.

- Tell me about different types of scaling (vertical vs horizontal)
    - Vertical Scaling (Scaling Up):
    Involves adding more power (CPU, RAM) to an existing server.
    Pros: Easier to implement, no need for software changes.
    Cons: Limited by hardware capacity, can lead to downtime during upgrades.
    - Horizontal Scaling (Scaling Out):
    Involves adding more servers to handle the load.
    Example: Adding additional servers to a load-balanced application.
    Pros: More flexible, no single point of failure, can handle more load.
    Cons: Requires software designed to distribute load, more complex to manage.

- What's the difference between public and private cloud?
    - Public Cloud:
    Services are delivered over the public internet and shared across multiple organizations.
    Examples: Amazon Web Services (AWS), Microsoft Azure, Google Cloud Platform (GCP).
    Pros: Cost-effective, no need to manage hardware, scalable.
    Cons: Less control, potential security concerns due to multi-tenancy.
    - Private Cloud:
    Services are maintained on a private network and used by a single organization.
    Examples: VMware, OpenStack.
    Pros: More control over data and security, customizable.
    Cons: More expensive, requires management of hardware and infrastructure.

- What is PaaS? When would you use that? What's an example of PaaS?
    - Platform as a Service (PaaS) provides a platform allowing customers to develop, run, and manage applications without dealing with the infrastructure.
    When to Use: Ideal for developers who want to focus on building and deploying applications without worrying about managing the underlying infrastructure.
    Example: Google App Engine, Microsoft Azure App Services.

- What is IaaS? When would you use that? What's an example of IaaS?
    - Infrastructure as a Service (IaaS) provides virtualized computing resources over the internet.
    When to Use: Suitable for companies that need to manage and control their own hardware and software but want to avoid the expense and complexity of buying and managing physical servers.
    Example: Amazon EC2, Microsoft Azure Virtual Machines.

- What is SaaS? When would you use that? What's an example of SaaS?
    - Software as a Service (SaaS) delivers software applications over the internet, on a subscription basis.
    When to Use: Ideal for end-users needing ready-to-use applications, such as email, CRM, or office tools, without worrying about underlying infrastructure or platform.
    Example: Google Workspace, Salesforce, Microsoft Office 365.

- What is SLA?
    - Service Level Agreement (SLA) is a formal contract between a service provider and a customer that specifies the level of service expected during the contract's term. It includes metrics such as uptime, performance benchmarks, response times, and resolution times for issues.

- What is a region in cloud? Why are they important?
    - A region in cloud computing is a specific geographic area where cloud resources and services are hosted. Each region consists of multiple isolated locations known as Availability Zones.
    Importance:
    Latency: Reducing the distance data needs to travel improves speed and performance.
    Compliance: Ensuring data residency requirements are met.
    Redundancy: Enhances disaster recovery and fault tolerance by distributing resources across different regions.
    
- Which cloud providers are there right now, other than Azure?
    - Amazon Web Services (AWS)
    - Google Cloud Platform (GCP)
    - IBM Cloud
    - Oracle Cloud Infrastructure (OCI)