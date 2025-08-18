# BMad Method Framework - Web Agent Bundle

This directory contains the complete BMad Method framework implementation for AI-assisted business analysis, market research, and strategic planning.

## Quick Start

To activate the analyst agent, use this command in any AI conversation:

```
I want to use the analyst agent from the BMad Method framework
```

The agent will activate and provide numbered command options for interaction.

## Framework Components

### Agents (`/agents/`)
- **analyst.md**: Business analyst agent with brainstorming, research, and documentation capabilities

### Tasks (`/tasks/`)
- **facilitate-brainstorming-session.md**: Interactive brainstorming facilitation
- **create-deep-research-prompt.md**: Generate comprehensive research prompts
- **create-doc.md**: YAML-driven document creation workflow
- **advanced-elicitation.md**: Structured content improvement techniques
- **document-project.md**: Comprehensive project documentation generation

### Templates (`/templates/`)
- **project-brief-tmpl.yaml**: Project brief and requirements documentation
- **market-research-tmpl.yaml**: Market research and analysis structure
- **competitor-analysis-tmpl.yaml**: Competitive intelligence documentation
- **brainstorming-output-tmpl.yaml**: Brainstorming session results capture

### Data (`/data/`)
- **bmad-kb.md**: Framework knowledge base and methodologies
- **brainstorming-techniques.md**: Comprehensive brainstorming technique library
- **elicitation-methods.md**: Advanced elicitation and analysis methods

### Utilities (`/utils/`)
- **template-format.md**: YAML template processing guidelines and utilities

## Usage Patterns

### 1. Project Documentation
Use the analyst agent's `document-project` command to create comprehensive documentation for existing codebases.

### 2. Market Research
Use the `perform-market-research` command to generate structured market analysis documents.

### 3. Brainstorming
Use the `brainstorm {topic}` command to facilitate interactive brainstorming sessions with structured output.

### 4. Research Planning
Use the `research-prompt {topic}` command to create detailed research prompts for further investigation.

## Framework Philosophy

The BMad Method emphasizes:
- **Evidence-based analysis** grounded in verifiable data
- **Structured methodologies** for consistent, thorough results
- **Collaborative facilitation** to guide users to their own insights
- **Action-oriented outputs** that support business decisions

## Integration with Development Projects

This framework has been applied to document the ScreenRecorderLib service project in this repository, demonstrating how the BMad Method can create comprehensive technical documentation for AI agent development.

## Getting Help

To see all available commands and options:
1. Activate the analyst agent
2. Use the `help` command to see numbered options
3. Select options by number for guided workflows

The framework is designed to be self-documenting and interactive, with built-in guidance for all processes.