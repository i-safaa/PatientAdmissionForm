# Patient Admission Form 🏥

A desktop-based Patient Admission Management application built with **C# Windows Forms** and **Microsoft SQL Server**. It provides an intuitive interface for hospital receptionists and administrators to register, manage, and store patient records securely and efficiently.

---

## 📌 Features

- **Intuitive UI:** Clean and responsive Windows Forms user interface for quick patient intake.
- **Comprehensive Patient Records:** Captures core patient demographics including Name, Age, Ethnicity, Gender, Blood Group, Residential Address, Email, and Phone Number.
- **Secure Database Integration:** Utilizes ADO.NET (`SqlCommand`, `SqlConnection`) with parameterized queries (`AddWithValue`) to ensure robust protection against SQL Injection attacks.
- **Input Handling & Confirmation:** User notifications via Windows Forms dialogs for successful data insertion and exception handling.

---

## 🛠️ Tech Stack

- **Language:** C# (.NET Framework)
- **GUI Framework:** Windows Forms (WinForms)
- **Database:** Microsoft SQL Server
- **Data Access:** ADO.NET (`System.Data.SqlClient`)
- **IDE:** Visual Studio 2022

---

## 🗄️ Database Schema

The application connects to a database named `HospitalDB` and operates on the `Patient` table:

```sql
CREATE TABLE [dbo].[Patient] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [Fname] VARCHAR(50) NOT NULL,
    [Gname] VARCHAR(50) NOT NULL,
    [Age] INT NOT NULL,
    [Ethnicity] VARCHAR(50) NOT NULL,
    [ResidentialAddress] VARCHAR(50) NOT NULL,
    [Eadd] NVARCHAR(50) NOT NULL,
    [Gender] VARCHAR(50) NOT NULL,
    [BGrop] VARCHAR(50) NOT NULL,
    [PNumber] VARCHAR(50) NOT NULL
);

