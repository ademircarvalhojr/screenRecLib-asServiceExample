# ScreenRecorderLib Service Example

A Windows service implementation demonstrating automated screen recording using the ScreenRecorderLib library and Topshelf framework.

## Overview

This project provides a complete example of how to implement screen recording as a Windows service. The service automatically captures screen content at regular intervals, saving video files to temporary storage locations.

## Features

- **Windows Service Integration**: Uses Topshelf for easy service installation and management
- **Automated Recording**: Timer-based screen capture every 10 seconds
- **Configurable Output**: H.264 video encoding with quality-based bitrate control
- **Comprehensive Logging**: Built-in logging for monitoring and troubleshooting
- **Service Lifecycle Management**: Full start, stop, pause, and continue support

## Quick Start

### Prerequisites
- Windows operating system
- .NET Core 3.1 or later
- Visual Studio 2019+ or VS Code with C# extension

### Building the Project
```bash
git clone https://github.com/ademircarvalhojr/screenRecLib-asServiceExample.git
cd screenRecLib-asServiceExample
dotnet restore
dotnet build
```

### Running as Console Application (for testing)
```bash
dotnet run --project src/ScreenRecorderLib.Service
```

### Installing as Windows Service
```bash
# Build release version
dotnet build -c Release

# Navigate to output directory
cd src/ScreenRecorderLib.Service/bin/x86/Release/netcoreapp3.1

# Install service
ScreenRecorderLib.Service.exe install

# Start service
ScreenRecorderLib.Service.exe start
```

### Service Management
```bash
# Stop service
ScreenRecorderLib.Service.exe stop

# Uninstall service
ScreenRecorderLib.Service.exe uninstall
```

## Architecture

The project consists of three main components:

1. **Program.cs**: Entry point and Topshelf service configuration
2. **ScreenRecorderLibService.cs**: Main service class with timer management
3. **ScreenRecorderLibHelper.cs**: Recording functionality wrapper

### Recording Flow
1. Service starts and initializes a 10-second timer
2. Timer triggers screen recording with predefined settings
3. Records for 5 seconds, then stops automatically
4. Saves video to temporary directory with random filename
5. Cycle repeats until service is stopped

## Configuration

Current configuration includes:
- **Recording Mode**: Video only
- **Encoder**: H.264 with Main profile
- **Bitrate Control**: Quality-based
- **Output Format**: MP4
- **Recording Interval**: 10 seconds
- **Recording Duration**: 5 seconds per capture

## Dependencies

- **ScreenRecorderLib**: Core screen recording functionality (v5.1.2)
- **Topshelf**: Windows service framework (v4.3.0)
- **.NET Core**: Runtime framework (v3.1)

## BMad Method Framework Integration

This repository now includes the **BMad Method Framework** - a comprehensive AI-assisted business analysis and documentation system.

### Framework Features
- **Analyst Agent**: AI business analyst with market research and brainstorming capabilities
- **Interactive Brainstorming**: Structured facilitation with multiple techniques
- **Document Generation**: YAML-driven template system with elicitation support
- **Research Planning**: Deep research prompt generation
- **Project Documentation**: Comprehensive codebase documentation for AI agents

### Framework Location
The complete framework is located in the `.bmad-core/` directory and includes:
- Agent configurations
- Task definitions
- Document templates
- Knowledge base
- Brainstorming techniques
- Elicitation methods

### Using the Framework
To activate the analyst agent in any AI conversation:
```
I want to use the analyst agent from the BMad Method framework
```

See [`.bmad-core/README.md`](.bmad-core/README.md) for complete framework documentation.

### Generated Documentation
The framework has been used to create comprehensive project documentation:
- **Project Documentation**: [`docs/project-documentation.md`](docs/project-documentation.md)

## Project Status

This is a demonstration/example project suitable for:
- Learning ScreenRecorderLib integration
- Understanding Windows service development
- Exploring automated recording solutions
- Training AI development agents

## License

This project is provided as-is for educational and demonstration purposes.

## Contributing

This is primarily an example project. For issues or suggestions, please use the GitHub issue tracker.

---

*This project now includes the BMad Method Framework for AI-assisted business analysis and documentation. The framework demonstrates advanced AI agent capabilities for market research, brainstorming, and comprehensive project documentation.*