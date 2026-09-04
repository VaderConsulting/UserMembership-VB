# UserMembership

VB.NET WinForms utility that looks up an Active Directory user by sAMAccountName and lists group membership plus account status flags. frmMain queries LDAP://RootDSE, loads memberOf and userAccountControl, and shows whether the account is disabled, locked, normal, password-never-expires, or expired. Handy for helpdesk staff who need a quick membership and status check without opening Active Directory Users and Computers.

**Source last updated:** 2008-02-17

---

## Contents

- `UserMembership.sln`
- `UserMembership/` - application source and forms

## Attribution and provenance

No third-party source attribution markers were identified during this review.

## Requirements

- Visual Studio 2008, .NET Framework 2.0

## License

MIT. See `LICENSE`.
