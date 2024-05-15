# Docker
## Docker Concepts/Terms
- What is containerization?
	- Containerization is a lightweight form of virtualization that involves encapsulating an application and its dependencies into a container. Containers are portable and consistent across different environments, ensuring that an application runs reliably regardless of where it is deployed.

- What problem are we solving with containerization and/or virtualization?
	- Containerization:
	Consistency: Ensures applications run the same in development, testing, and production environments.
	Isolation: Isolates applications from each other on the same host, avoiding conflicts.
	Portability: Containers can run on any system that supports the container runtime, making deployment easier.
	Efficiency: Containers are lightweight and share the host OS kernel, leading to better resource utilization compared to traditional virtual machines.
	- Virtualization:
	Resource Utilization: Maximizes hardware usage by running multiple virtual machines (VMs) on a single physical server.
	Isolation: Provides strong isolation between VMs, each with its own OS.
	Scalability: Allows easy scaling by adding more VMs.

- How is containerization different from virtualization?
	- Containerization:
	Lightweight: Containers share the host OS kernel and are typically smaller and faster to start.
	Resource Efficiency: Uses less memory and CPU compared to VMs.
	Portability: Easier to move and replicate across different environments.
	- Virtualization:
	Heavyweight: Each VM includes a full OS, making them larger and slower to start.
	Isolation: Stronger isolation since each VM is fully separated by its own OS.
	Resource Intensive: Uses more memory and CPU due to running full OS instances.

- What is docker?
	- Docker is a platform that uses containerization to help developers and IT operations build, ship, and run applications consistently across different environments. Docker simplifies the management and deployment of applications in containers.

- What is docker engine?
	- Docker Engine is the runtime that builds and runs Docker containers. It consists of a server (a daemon process), a REST API for interacting with the daemon, and a command-line interface (CLI).

- what is dockerfile?
	- A Dockerfile is a text file containing a series of instructions on how to build a Docker image. Each instruction in a Dockerfile creates a layer in the image.

- what is .dockerignore file?
	- A .dockerignore file is used to specify files and directories that should be ignored by the Docker build process. This helps reduce the build context size and avoid unnecessary files being added to the image.

- what is image?
	- A Docker image is a lightweight, standalone, executable package that includes everything needed to run a piece of software, including the code, runtime, libraries, environment variables, and configuration files. Images are read-only templates used to create containers.

- what is container?
	- A container is a runtime instance of a Docker image. It includes the application and all its dependencies, packaged together. Containers are isolated but share the OS kernel with the host and other containers.

- what is a tag?
	- A tag is a label applied to a Docker image to differentiate versions. The most common tag is latest, but you can use tags to manage multiple versions of your application, like v1.0, v2.0, etc.

- what is image registry?
	- An image registry is a storage and distribution system for Docker images. The most common public registry is Docker Hub, but private registries can also be set up.

- What is base image?
	- A base image is the starting point for building a Docker image, often defined in the FROM instruction in a Dockerfile. It is usually a minimal OS image or a runtime environment like alpine, ubuntu, or node.


## Docker Commands
- What command do you use to build an image
	- `docker build`
    - `docker build -t dockerhubusername/imagename:tag-name relative-path-to-folder-containing-dockerfile`
    - ex: `docker build -t sminseonong/pokestorage:latest .`

- How do you run an image in a container?
    -`docker run image-name`
    - `-d` "detached" runs the container in the background
    - `-p host:container` to map container port to host machine
    - `docker run -d -p 8080:8080 aschil/snake`
    - `-i` interactive for your interactive console applications

- To see all your local images:
    - `docker image ls`
- to remove your local image
    - `docker image rm image-name-or-image-id`
- the above two commands are the same for containers as well
    - `docker container ls`
    - `docker container rm container-id`
- when in doubt, `docker resource-name --help`


- In dockerfile...
	- What does FROM do?
	FROM: Specifies the base image to use for the subsequent instructions.

	- WORKDIR ?
	WORKDIR: Sets the working directory inside the container.

	- RUN?
	RUN: Executes a command during the image build process.

	- CMD?
	CMD: Specifies the command to run when a container starts. It can be overridden by arguments to docker run.

	- ENTRYPOINT?
	ENTRYPOINT: Configures a container to run as an executable.

- how do you push/pull image from image registry?
	- To download image from docker hub
    - `docker pull image-name`
	
	- To upload image to docker hub
    - `docker push image-name`