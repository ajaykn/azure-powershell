---
external help file: Az.Communication-help.xml
Module Name: Az.Communication
online version: https://learn.microsoft.com/powershell/module/az.communication/stop-azemailservicedomainverification
schema: 2.0.0
---

# Stop-AzEmailServiceDomainVerification

## SYNOPSIS
Cancel verification of DNS record.

## SYNTAX

### CancelExpanded (Default)
```
Stop-AzEmailServiceDomainVerification -DomainName <String> -EmailServiceName <String>
 -ResourceGroupName <String> [-SubscriptionId <String>] -VerificationType <String> [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CancelViaJsonString
```
Stop-AzEmailServiceDomainVerification -DomainName <String> -EmailServiceName <String>
 -ResourceGroupName <String> [-SubscriptionId <String>] -JsonString <String> [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CancelViaJsonFilePath
```
Stop-AzEmailServiceDomainVerification -DomainName <String> -EmailServiceName <String>
 -ResourceGroupName <String> [-SubscriptionId <String>] -JsonFilePath <String> [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CancelViaIdentityEmailServiceExpanded
```
Stop-AzEmailServiceDomainVerification -DomainName <String> -EmailServiceInputObject <IEmailServiceIdentity>
 -VerificationType <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CancelViaIdentityEmailService
```
Stop-AzEmailServiceDomainVerification -DomainName <String> -EmailServiceInputObject <IEmailServiceIdentity>
 -Parameter <IVerificationParameter> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Cancel
```
Stop-AzEmailServiceDomainVerification -DomainName <String> -EmailServiceName <String>
 -ResourceGroupName <String> [-SubscriptionId <String>] -Parameter <IVerificationParameter>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CancelViaIdentityExpanded
```
Stop-AzEmailServiceDomainVerification -InputObject <IEmailServiceIdentity> -VerificationType <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CancelViaIdentity
```
Stop-AzEmailServiceDomainVerification -InputObject <IEmailServiceIdentity> -Parameter <IVerificationParameter>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Cancel verification of DNS record.

## EXAMPLES

### Example 1: Stop domain verification for domain resource.
```powershell
Stop-AzEmailServiceDomainVerification  -DomainName testcustomdomain1.net  -EmailServiceName ContosoAcsResource1 -ResourceGroupName ContosoResourceProvider1 -VerificationType Domain
```

Stop domain verification for domain resource.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainName
The name of the Domains resource.

```yaml
Type: System.String
Parameter Sets: CancelExpanded, CancelViaJsonString, CancelViaJsonFilePath, CancelViaIdentityEmailServiceExpanded, CancelViaIdentityEmailService, Cancel
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailServiceInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models.IEmailServiceIdentity
Parameter Sets: CancelViaIdentityEmailServiceExpanded, CancelViaIdentityEmailService
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EmailServiceName
The name of the EmailService resource.

```yaml
Type: System.String
Parameter Sets: CancelExpanded, CancelViaJsonString, CancelViaJsonFilePath, Cancel
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models.IEmailServiceIdentity
Parameter Sets: CancelViaIdentityExpanded, CancelViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Cancel operation

```yaml
Type: System.String
Parameter Sets: CancelViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Cancel operation

```yaml
Type: System.String
Parameter Sets: CancelViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
Input parameter for verification APIs

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models.IVerificationParameter
Parameter Sets: CancelViaIdentityEmailService, Cancel, CancelViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: System.Management.Automation.ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: CancelExpanded, CancelViaJsonString, CancelViaJsonFilePath, Cancel
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String
Parameter Sets: CancelExpanded, CancelViaJsonString, CancelViaJsonFilePath, Cancel
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -VerificationType
Type of verification.

```yaml
Type: System.String
Parameter Sets: CancelExpanded, CancelViaIdentityEmailServiceExpanded, CancelViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models.IEmailServiceIdentity

### Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models.IVerificationParameter

## OUTPUTS

### System.Boolean

## NOTES

## RELATED LINKS
