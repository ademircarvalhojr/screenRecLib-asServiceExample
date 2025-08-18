# ScreenRecorderLib Service Project Documentation

*Generated using BMad Method Framework - Document Project Task*

## Project Overview

### Purpose and Goals
The ScreenRecorderLib Service is a Windows service application that provides automated screen recording capabilities. Built as a demonstration of how to implement the ScreenRecorderLib library as a background service, it records the screen at regular intervals and saves video files to temporary locations.

### Target Users
- **Developers**: Seeking examples of ScreenRecorderLib integration
- **System Administrators**: Looking to deploy automated recording solutions
- **Security Teams**: Implementing monitoring and audit capabilities
- **DevOps Engineers**: Integrating screen recording into automated workflows

### Key Features
- **Automated Recording**: Timer-based screen capture every 10 seconds
- **Service Architecture**: Runs as Windows service using Topshelf framework
- **Configurable Output**: Records to temporary directory with random filenames
- **Logging Support**: Integrated logging for troubleshooting and monitoring
- **Service Control**: Standard Windows service start/stop/pause functionality

### Business Context
This project serves as a reference implementation for organizations needing:
- Automated screen monitoring solutions
- Compliance and audit trail capabilities
- Developer training and education materials
- Foundation for custom screen recording applications

## Technical Architecture

### System Architecture
```
┌─────────────────┐    ┌──────────────────┐    ┌─────────────────┐
│   Windows       │    │  ScreenRecorder  │    │  ScreenRecorder │
│   Service       │───▶│  Lib Service     │───▶│  Lib Helper     │
│   Host          │    │  (Timer-based)   │    │  (Recording)    │
│   (Topshelf)    │    └──────────────────┘    └─────────────────┘
└─────────────────┘              │                       │
                                 │                       │
                                 ▼                       ▼
                    ┌──────────────────┐    ┌─────────────────┐
                    │   File System    │    │ ScreenRecorder  │
                    │   (Temp Files)   │    │ Lib (External)  │
                    └──────────────────┘    └─────────────────┘
```

### Technology Stack
- **Framework**: .NET Core 3.1
- **Service Framework**: Topshelf 4.3.0
- **Recording Library**: ScreenRecorderLib 5.1.2
- **Language**: C# 
- **Platform**: Windows (x86 architecture)
- **Build System**: MSBuild/.NET CLI

### Data Flow
1. **Service Startup**: Topshelf initializes and starts the service
2. **Timer Activation**: Service starts 10-second interval timer
3. **Recording Initiation**: Timer triggers screen recording start
4. **Recording Duration**: Records for 5 seconds
5. **Recording Completion**: Stops recording and saves to temp file
6. **Cycle Repeat**: Timer continues cycle until service stops

### Integration Points
- **ScreenRecorderLib**: External NuGet package providing core recording functionality
- **Windows Service Manager**: Standard Windows service integration
- **File System**: Temporary directory for video output storage
- **Windows Graphics**: Screen capture through Windows APIs

### Security Model
- **Service Account**: Runs as LocalSystem account
- **File Permissions**: Creates files in temp directory with system permissions
- **Screen Access**: Requires appropriate permissions for screen capture
- **No Authentication**: Direct service operation without user authentication

## Development Environment

### Setup Instructions
1. **Prerequisites**:
   - Visual Studio 2019 or later / VS Code with C# extension
   - .NET Core 3.1 SDK or later
   - Windows operating system (for service functionality)

2. **Clone Repository**:
   ```bash
   git clone https://github.com/ademircarvalhojr/screenRecLib-asServiceExample.git
   cd screenRecLib-asServiceExample
   ```

3. **Restore Dependencies**:
   ```bash
   dotnet restore
   ```

4. **Build Project**:
   ```bash
   dotnet build
   ```

### Build Process
- **Solution File**: `ScreenRecorderLib.Service.sln`
- **Project File**: `src/ScreenRecorderLib.Service/ScreenRecorderLib.Service.csproj`
- **Build Configuration**: Debug/Release with x86 platform
- **Output**: Executable service application

### Testing Strategy
- **Manual Testing**: Run service locally for verification
- **Service Testing**: Install as Windows service and verify operation
- **Output Verification**: Check video files are created correctly
- **Performance Testing**: Monitor resource usage during operation

### Development Workflow
1. **Local Development**: Build and run console application
2. **Service Testing**: Use Topshelf run command for testing
3. **Service Installation**: Use Topshelf install command for deployment
4. **Monitoring**: Check Windows Event Log for service status

### Common Tasks
- **Run Locally**: `dotnet run` from project directory
- **Service Install**: `ScreenRecorderLib.Service.exe install`
- **Service Start**: `ScreenRecorderLib.Service.exe start`
- **Service Stop**: `ScreenRecorderLib.Service.exe stop`
- **Service Uninstall**: `ScreenRecorderLib.Service.exe uninstall`

## Code Organization

### Directory Structure
```
screenRecLib-asServiceExample/
├── .gitignore                          # Git ignore rules
├── ScreenRecorderLib.Service.sln       # Visual Studio solution
├── src/
│   └── ScreenRecorderLib.Service/
│       ├── Program.cs                  # Application entry point
│       ├── ScreenRecorderLibService.cs # Main service implementation
│       ├── ScreenRecorderLibHelper.cs  # Recording functionality
│       └── ScreenRecorderLib.Service.csproj # Project configuration
└── .bmad-core/                         # BMad Method framework
    ├── agents/                         # AI agent configurations
    ├── tasks/                          # Framework tasks
    ├── templates/                      # Document templates
    ├── data/                           # Knowledge base and techniques
    └── utils/                          # Utility functions
```

### Module Breakdown

#### Program.cs
- **Purpose**: Application entry point and service configuration
- **Responsibilities**: 
  - Topshelf service host configuration
  - Service lifecycle management (start, stop, pause, continue)
  - Service metadata (name, description, display name)
- **Key Components**: HostFactory configuration, service registration

#### ScreenRecorderLibService.cs
- **Purpose**: Main service implementation class
- **Responsibilities**:
  - Timer management for periodic recording
  - Service lifecycle event handling
  - Coordination between timer and recording functionality
- **Key Components**: Timer instance, event handlers, service state management

#### ScreenRecorderLibHelper.cs
- **Purpose**: Screen recording functionality wrapper
- **Responsibilities**:
  - ScreenRecorderLib integration
  - Recording configuration and options
  - Event handling for recording status
  - Logging and error handling
- **Key Components**: Recorder instance, configuration options, event handlers

### Naming Conventions
- **Classes**: PascalCase (e.g., `ScreenRecorderLibService`)
- **Methods**: PascalCase (e.g., `StartRecording`)
- **Variables**: camelCase (e.g., `videoPath`)
- **Private Fields**: _underscore prefix (e.g., `_Recorder`)
- **Constants**: UPPER_CASE (e.g., service configuration values)

### Code Patterns
- **Service Pattern**: Topshelf-based service implementation
- **Event-Driven**: Recording status handled through events
- **Static Helper**: Utility methods in static helper class
- **Configuration-Based**: Options pattern for recording settings
- **Resource Management**: Proper disposal of recording resources

### Configuration Management
- **Project Configuration**: Defined in `.csproj` file
- **Recording Options**: Hardcoded in `ScreenRecorderLibHelper`
- **Service Settings**: Configured in `Program.cs`
- **Runtime Paths**: Generated dynamically for temp file storage

## Deployment and Operations

### Deployment Process
1. **Build Release**: `dotnet build -c Release`
2. **Copy Executable**: Deploy binaries to target system
3. **Install Service**: Run `ScreenRecorderLib.Service.exe install`
4. **Start Service**: Use Windows Service Manager or command line
5. **Verify Operation**: Check Event Log and output files

### Environment Configuration
- **Development**: Local machine with Visual Studio
- **Testing**: Windows VM or test environment
- **Production**: Windows server with appropriate permissions

### Monitoring and Logging
- **Service Status**: Windows Service Manager
- **Application Logs**: ScreenRecorderLib internal logging
- **Event Logs**: Windows Event Log integration through Topshelf
- **File Output**: Monitor temp directory for video files

### Troubleshooting Guide
- **Service Won't Start**: Check permissions and dependencies
- **No Video Files**: Verify screen access permissions
- **Performance Issues**: Monitor CPU and memory usage
- **File Access Errors**: Check temp directory permissions

### Performance Considerations
- **Memory Usage**: Recording library may consume significant memory
- **CPU Impact**: Screen capture is CPU-intensive
- **Disk Space**: Video files accumulate in temp directory
- **Timer Frequency**: 10-second intervals balance functionality and performance

## Agent Development Guide

### Getting Started for AI Agents
1. **Understanding the Architecture**: Review the three main components and their relationships
2. **Key Entry Points**: Start with `Program.cs` for service configuration
3. **Core Functionality**: Focus on `ScreenRecorderLibHelper.cs` for recording logic
4. **Testing Approach**: Use console mode before service installation

### Common Patterns for AI Agents
- **Service Lifecycle**: Follow Topshelf patterns for service operations
- **Error Handling**: Use try-catch blocks with logging for robustness
- **Resource Management**: Ensure proper disposal of recording resources
- **Configuration**: Use strongly-typed options for settings

### Testing Requirements for AI Agents
- **Build Verification**: Ensure project builds without errors
- **Basic Functionality**: Verify recording starts and stops correctly
- **File Output**: Confirm video files are created successfully
- **Service Operations**: Test install/start/stop operations

### Code Review Criteria
- **Memory Management**: Proper disposal of recording instances
- **Error Handling**: Comprehensive exception handling
- **Logging**: Appropriate log messages for debugging
- **Thread Safety**: Consider timer and recording thread interactions

### Restricted Areas
- **ScreenRecorderLib Integration**: Requires careful handling of external library
- **Service Configuration**: Changes may affect service installation
- **Timer Management**: Critical for service operation timing
- **File Path Generation**: Security considerations for temp file creation

---

*This documentation was generated using the BMad Method framework to provide comprehensive project understanding for both human developers and AI agents working on the ScreenRecorderLib service project.*