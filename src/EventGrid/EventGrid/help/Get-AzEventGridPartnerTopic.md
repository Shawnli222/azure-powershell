---
external help file: Microsoft.Azure.PowerShell.Cmdlets.EventGrid.dll-Help.xml
Module Name: Az.EventGrid
online version: https://learn.microsoft.com/powershell/module/az.eventgrid/get-azeventgridpartnertopic
schema: 2.0.0
---

# Get-AzEventGridPartnerTopic

## SYNOPSIS
Gets the details of an Event Grid partner topic, or gets a list of Event Grid partner topics.

## SYNTAX

### ResourceGroupNameParameterSet (Default)
```
Get-AzEventGridPartnerTopic [-ResourceGroupName <String>] [-ODataQuery <String>] [-Top <Int32>]
 [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

### PartnerTopicNameParameterSet
```
Get-AzEventGridPartnerTopic -ResourceGroupName <String> -Name <String>
 [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

### NextLinkParameterSet
```
Get-AzEventGridPartnerTopic -NextLink <String> [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

## DESCRIPTION
The Get-AzEventGridPartnerTopic cmdlet either gets the details of a specified Event Grid partner topic, or a list of Event Grid partner topics.
If the partner topic name is provided, the details of a single partner topic is returned.
If the partner topic name is not provided but the resource group name is provided, a list of partner topics a the resource group scope is returned.
If neither the partner topic name or the resource group name is provided, a list of partner topics in the current Azure subscription is returned.

## EXAMPLES

### Example 1
```powershell
Get-AzEventGridPartnerTopic -ResourceGroupName MyResourceGroupName -Name PartnerTopic1
```

Gets the details of Event Grid partner topic \`PartnerTopic1\` in resource group \`MyResourceGroupName\`.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Event Grid partner topic name.

```yaml
Type: System.String
Parameter Sets: PartnerTopicNameParameterSet
Aliases: PartnerTopicName

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -NextLink
The link for the next page of resources to be obtained.
This value is obtained with the first Get-AzEventGrid cmdlet call when more resources are still available to be queried.

```yaml
Type: System.String
Parameter Sets: NextLinkParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ODataQuery
The OData query used for filtering the list results.
Filtering is currently allowed on the Name property only.The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.

```yaml
Type: System.String
Parameter Sets: ResourceGroupNameParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: ResourceGroupNameParameterSet
Aliases: ResourceGroup

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

```yaml
Type: System.String
Parameter Sets: PartnerTopicNameParameterSet
Aliases: ResourceGroup

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Top
The maximum number of resources to be obtained.
Valid value is between 1 and 100.
If top value is specified and more results are still available, the result will contain a link to the next page to be queried in NextLink.
If the Top value is not specified, the full list of resources will be returned at once.

```yaml
Type: System.Nullable`1[System.Int32]
Parameter Sets: ResourceGroupNameParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

### System.Nullable`1[[System.Int32, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]

## OUTPUTS

### Microsoft.Azure.Commands.EventGrid.Models.PSPartnerTopic

### Microsoft.Azure.Commands.EventGrid.Models.PSSytemTopicListInstance

## NOTES

## RELATED LINKS
