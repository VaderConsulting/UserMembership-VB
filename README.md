# UserMembership

VB.NET WinForms utility that looks up an Active Directory user by sAMAccountName and lists group membership plus account status flags. frmMain queries LDAP://RootDSE, loads memberOf and userAccountControl, and shows whether the account is disabled, locked, normal, password-never-expires, or expired. Handy for helpdesk staff who need a quick membership and status check without opening Active Directory Users and Computers.

**Source last updated:** 2008-02-18 · **Language:** VB.NET · **Target:** .NET Framework 2.0 · **Output:** WinForms exe

---

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `UserMembership` (`UserMembership/UserMembership.vbproj`) | VB.NET | WinForms exe (.NET 2.0) | `frmMain` AD lookup of memberOf and userAccountControl flags |

## How to open

Open `UserMembership.sln` in Visual Studio 2008 (solution format 10.00, ToolsVersion 3.5) and run the `UserMembership` project on a domain-joined machine.

## Requirements

- Visual Studio 2008, .NET Framework 2.0
- Domain-joined Windows machine with Active Directory access (System.DirectoryServices)

## Attribution and provenance

Working copy from my Historical Dev folder.

Working copy from my Development folder `UserMembership-VB`. No third-party source attribution markers were identified.

## License

MIT © 2026 VaderConsulting for Dave Robinson's code. See `LICENSE`.
