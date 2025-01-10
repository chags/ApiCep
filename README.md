# Apicep

Apicep is an API built using .NET Core 9 and the SACALA stack. It provides functionalities to manage and validate postal codes (CEPs) in a scalable and efficient manner.

## Features
- Validate Brazilian postal codes (CEPs).
- Retrieve JSON data for a given CEP.
- Handle invalid or non-existent CEPs gracefully.

## Requirements
- .NET Core 9 SDK
- A modern code editor (e.g., Visual Studio, Visual Studio Code)
- Optional: Docker (for containerized deployments)

## Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/apicep.git
   cd apicep
   ```
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
3. Build the project:
   ```bash
   dotnet build
   ```

## Usage

### Running the API locally
1. Start the application:
   ```bash
   dotnet run
   ```
2. Access the API at `http://localhost:5000`.

### Endpoints
#### `GET /v1/{cep}`
- **Description:** Retrieves information for the specified CEP.
- **Parameters:**
  - `cep`: A valid 8-digit postal code (e.g., `61652500`).
- **Responses:**
  - `200 OK`: Returns JSON data for the CEP.
  - `400 Bad Request`: Invalid CEP format.
  - `404 Not Found`: CEP not found.

Example:
```bash
GET http://localhost:5000/v1/61652500
```
Response:
```json
{
  "address": "Rua Exemplo",
  "city": "Fortaleza",
  "state": "CE"
}
```

## File Structure
```
Apicep/
├── Controllers/
│   └── CepController.cs  # Handles API requests
├── Models/
│   └── CepModel.cs       # Data structure for CEPs
├── Services/
│   └── CepService.cs     # Business logic for CEP handling
├── appsettings.json      # Application configuration
├── Program.cs            # Entry point of the application
└── Startup.cs            # Configures services and middleware
```

## Testing
Run the tests to ensure everything is working correctly:
```bash
dotnet test
```

## Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a feature branch: `git checkout -b feature-name`.
3. Commit your changes: `git commit -m 'Add new feature'`.
4. Push to your branch: `git push origin feature-name`.
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact
For questions or support, please reach out to [your email or contact info].

# ApiCep
 
