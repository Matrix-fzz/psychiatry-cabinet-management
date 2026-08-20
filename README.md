# Psychiatry Cabinet Management System

A desktop application for managing a psychiatric practice, including patients, appointments, treatments, medications, medical records, and finances.

## Features

- **User Authentication** — Login with role-based access (Doctor, Secretary, Intern)
- **Patient Management** — Full CRUD with medical history, insurance, and treatment tracking
- **Medical Records** — Create and manage patient dossiers linked to treatments
- **Appointment Scheduling** — Book and manage patient appointments
- **Medication Management** — Track medications with dosage, posology, and observations
- **Financial Management** — Track office expenses (electricity, water, rent, salaries)
- **Report Generation** — Crystal Reports integration for printable documents

## Technologies

| Technology | Usage |
|------------|-------|
| VB.NET | All application logic |
| .NET Framework 4.0 | Runtime framework |
| Windows Forms (WinForms) | Desktop UI |
| Microsoft SQL Server | Database (via ADO.NET) |
| Crystal Reports | Report generation |
| Bunifu UI v1.5.3 | Modern UI controls |
| DevComponents.DotNetBar2 v8.8.0 | UI components |

## Database

- **Engine:** Microsoft SQL Server
- **Database Name:** `CABINETPSYCHAITRE`
- **Tables:** UTILISATEUR, PATIENT, DOSSIER, TRAITEMENT, MEDICAMEN, RESERVER, GESTIONFINNANCIER

## Requirements

- Visual Studio 2010+
- .NET Framework 4.0
- Microsoft SQL Server
- Bunifu UI and DevComponents.DotNetBar2 DLLs (included in project references)

## How to Run

1. Open `GESTION CABINET DE PSYCHIATRIE.sln` in Visual Studio
2. Ensure SQL Server is running with the `CABINETPSYCHAITRE` database created
3. Update the connection string in `Module1.vb` if needed
4. Build and run the project
