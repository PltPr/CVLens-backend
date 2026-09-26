<h1>
  <img src="./cv-wh.svg" width=32 height="32" alt="">
  CVLens
</h1>

An AI-powered recruitment platform that allows candidates to apply for job offers with their CVs. Submitted CVs are processed through OCR and evaluated by a local LLM against the requirements of the selected job offer, generating a score and detailed evaluation for recruiters.

## Flow

```text
Candidate
    ↓
Registration / Login
    ↓
JWT Authentication
    ↓
Job Offer
    ↓
Application + PDF CV
    ↓
Application Queue
    ↓
Background Service
    ↓
┌───────────────────────────────┐
│        CV Processing          │
│                               │
│  PDF → OCR                    │
│       ↓                       │
│  Extracted CV Text            │
│       ↓                       │
│  Job Offer + CV               │
│       ↓                       │
│  Ollama / Qwen                │
│       ↓                       │
│  Score + Evaluation           │
└───────────────────────────────┘
    ↓
Application Update
    ↓
Recruiter
    ↓
Review Applications
```

## Implementation

Built with **ASP.NET Core**, **Entity Framework Core**, **ASP.NET Identity**, **JWT**, **PostgreSQL**, **Dapper**, **OCR.Space**, **Ollama**, **BackgroundService**, **ConcurrentQueue** and **Swagger**.

Authentication and authorization are handled with **ASP.NET Identity**, JWT tokens and role-based access control. Requests are protected with **rate limiting**, while a custom **GlobalExceptionHandler** provides centralized exception handling and consistent `ProblemDetails` responses.

CV processing is performed asynchronously using an in-memory queue and `BackgroundService`, separating application submission from the more time-consuming OCR and AI evaluation process. **OCR.Space** extracts text from uploaded PDF files, which is then analyzed by a local **Qwen 2.5** model running through **Ollama**.

The backend uses **Entity Framework Core** for application data and **Dapper** for reporting queries, with repository and service layers separating data access, business logic and external integrations.
