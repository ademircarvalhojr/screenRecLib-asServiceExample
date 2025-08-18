# Document an Existing Project

## Purpose

Generate comprehensive documentation for existing projects optimized for AI development agents. This task creates structured reference materials that enable AI agents to understand project context, conventions, and patterns for effective contribution to any codebase.

## Task Instructions

### 1. Initial Project Analysis

**CRITICAL:** First, check if a PRD or requirements document exists in context. If yes, use it to focus your documentation efforts on relevant areas only.

**IF PRD EXISTS**:

- Review the PRD to understand what enhancement/feature is planned
- Identify which modules, services, or areas will be affected
- Focus documentation ONLY on these relevant areas
- Skip unrelated parts of the codebase to keep docs lean

**IF NO PRD EXISTS**:
Ask the user:

"I notice you haven't provided a PRD or requirements document. To create more focused and useful documentation, I recommend one of these options:

1. **Create a PRD first** - Would you like me to help create a brownfield PRD before documenting? This helps focus documentation on relevant areas.

2. **Provide existing requirements** - Do you have a requirements document, epic, or feature description you can share?

3. **Describe the focus** - Can you briefly describe what enhancement or feature you're planning? For example:
   - 'Adding payment processing to the user service'
   - 'Refactoring the authentication module'
   - 'Integrating with a new third-party API'

4. **Document everything** - Or should I proceed with comprehensive documentation of the entire codebase? (Note: This may create excessive documentation for large projects)

Please let me know your preference, or I can proceed with full documentation if you prefer."

Based on their response:

- If they choose option 1-3: Use that context to focus documentation
- If they choose option 4 or decline: Proceed with comprehensive analysis below

Begin by conducting analysis of the existing project. Use available tools to:

1. **Project Structure Discovery**: Examine the root directory structure, identify main folders, and understand the overall organization
2. **Technology Stack Identification**: Look for package.json, requirements.txt, Cargo.toml, pom.xml, etc. to identify languages, frameworks, and dependencies
3. **Build System Analysis**: Find build scripts, CI/CD configurations, and development commands
4. **Existing Documentation Review**: Check for README files, docs folders, and any existing documentation
5. **Code Pattern Analysis**: Sample key files to understand coding patterns, naming conventions, and architectural approaches

Ask the user these elicitation questions to better understand their needs:

- What is the primary purpose of this project?
- Are there any specific areas of the codebase that are particularly complex or important for agents to understand?
- What types of tasks do you expect AI agents to perform on this project? (e.g., bug fixes, feature additions, refactoring, testing)
- Are there any existing documentation standards or formats you prefer?
- What level of technical detail should the documentation target? (junior developers, senior developers, mixed team)
- Is there a specific feature or enhancement you're planning? (This helps focus documentation)

### 2. Deep Codebase Analysis

CRITICAL: Before generating documentation, conduct extensive analysis of the existing codebase:

1. **Explore Key Areas**:
   - Entry points (main files, index files, app initializers)
   - Configuration files and environment setup
   - Package dependencies and versions
   - Database schemas and migrations (if applicable)
   - API endpoints and routes (if applicable)
   - Core business logic and domain models
   - Utility functions and helpers
   - Test files and testing patterns

2. **Identify Architectural Patterns**:
   - Overall architectural style (MVC, microservices, layered, etc.)
   - Design patterns in use
   - Data flow and communication patterns
   - Error handling approaches
   - Logging and monitoring patterns

3. **Understand Dependencies**:
   - External libraries and frameworks
   - Internal module dependencies
   - Database and external service dependencies
   - Development and deployment dependencies

### 3. Documentation Generation

Generate structured documentation organized into these core sections:

#### A. Project Overview
- **Purpose and Goals**: What problem does this project solve?
- **Target Users**: Who uses this system and how?
- **Key Features**: Primary capabilities and functionality
- **Business Context**: How this fits into larger organizational goals

#### B. Technical Architecture
- **System Architecture**: High-level component diagram and explanation
- **Technology Stack**: Languages, frameworks, databases, key libraries
- **Data Flow**: How information moves through the system
- **Integration Points**: External APIs, services, and dependencies
- **Security Model**: Authentication, authorization, data protection

#### C. Development Environment
- **Setup Instructions**: Step-by-step environment setup
- **Build Process**: How to compile/build the project
- **Testing Strategy**: How to run tests, test organization
- **Development Workflow**: Branching, PR process, deployment
- **Common Tasks**: Frequent development operations

#### D. Code Organization
- **Directory Structure**: Explanation of folder organization
- **Module Breakdown**: Purpose of each major component
- **Naming Conventions**: Patterns used for files, classes, functions
- **Code Patterns**: Common architectural patterns and idioms
- **Configuration Management**: How settings and config are handled

#### E. API Documentation (if applicable)
- **Endpoint Inventory**: Complete list of API endpoints
- **Request/Response Formats**: Data structures and examples
- **Authentication Requirements**: How to authenticate requests
- **Error Handling**: Error codes and response formats
- **Rate Limiting**: Any usage limitations or throttling

#### F. Database Schema (if applicable)
- **Entity Relationship Diagram**: Visual representation of data model
- **Table Descriptions**: Purpose and structure of each table
- **Key Relationships**: How entities connect and reference each other
- **Indexes and Performance**: Important database optimizations
- **Migration History**: Schema evolution and update processes

#### G. Deployment and Operations
- **Deployment Process**: How code gets to production
- **Environment Configuration**: Differences between dev/staging/prod
- **Monitoring and Logging**: How to observe system health
- **Troubleshooting Guide**: Common issues and solutions
- **Performance Considerations**: Known bottlenecks and optimizations

#### H. Agent Development Guide
- **Getting Started**: Quick start for AI agents working on this project
- **Common Patterns**: Code patterns agents should follow
- **Testing Requirements**: How agents should test their changes
- **Code Review Criteria**: What human reviewers will check for
- **Restricted Areas**: Code that requires special care or human oversight

### 4. Documentation Quality Assurance

Before finalizing documentation:

1. **Accuracy Verification**: Cross-check all technical details against actual code
2. **Completeness Check**: Ensure all major components are covered
3. **Clarity Assessment**: Verify explanations are clear for target audience
4. **Example Validation**: Test all code examples and instructions
5. **Update Currency**: Confirm information reflects current codebase state

### 5. Output Format Options

Present documentation in multiple formats as appropriate:

1. **Markdown Files**: Organized in logical hierarchy for easy navigation
2. **README Updates**: Enhanced project README with essential information
3. **Wiki Pages**: Structured knowledge base format
4. **Code Comments**: Inline documentation improvements
5. **Architecture Diagrams**: Visual representations of system structure

### 6. Maintenance Strategy

Provide guidance for keeping documentation current:

1. **Documentation Ownership**: Who is responsible for updates
2. **Update Triggers**: When documentation should be revised
3. **Review Process**: How to validate documentation accuracy
4. **Version Control**: How to track documentation changes
5. **Feedback Loop**: How to collect and incorporate user feedback

## Success Criteria

Documentation is successful when:

- New team members can understand and contribute to the project quickly
- AI agents can effectively navigate and modify the codebase
- Common questions are answered without human intervention
- System architecture and design decisions are clearly explained
- Development workflow is documented and followable
- Technical debt and improvement opportunities are identified

## Common Pitfalls to Avoid

- Creating documentation that becomes outdated quickly
- Over-documenting obvious or self-explanatory code
- Under-documenting complex business logic and architectural decisions
- Focusing only on happy path scenarios
- Ignoring error handling and edge cases
- Missing integration and deployment details
- Not considering different user personas (junior vs senior developers)