// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RouteFilterRulesOperations.
    /// </summary>
    public static partial class RouteFilterRulesOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified rule from a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static void Delete(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName)
            {
                operations.DeleteAsync(resourceGroupName, routeFilterName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified rule from a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified rule from a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static RouteFilterRuleInner Get(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName)
            {
                return operations.GetAsync(resourceGroupName, routeFilterName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified rule from a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilterRuleInner> GetAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the create or update route filter rule operation.
            /// </param>
            public static RouteFilterRuleInner CreateOrUpdate(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, RouteFilterRuleInner routeFilterRuleParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the create or update route filter rule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilterRuleInner> CreateOrUpdateAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, RouteFilterRuleInner routeFilterRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the update route filter rule operation.
            /// </param>
            public static RouteFilterRuleInner Update(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, PatchRouteFilterRuleInner routeFilterRuleParameters)
            {
                return operations.UpdateAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the update route filter rule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilterRuleInner> UpdateAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, PatchRouteFilterRuleInner routeFilterRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all RouteFilterRules in a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            public static IPage<RouteFilterRuleInner> ListByRouteFilter(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName)
            {
                return operations.ListByRouteFilterAsync(resourceGroupName, routeFilterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all RouteFilterRules in a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RouteFilterRuleInner>> ListByRouteFilterAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRouteFilterWithHttpMessagesAsync(resourceGroupName, routeFilterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified rule from a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static void BeginDelete(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName)
            {
                operations.BeginDeleteAsync(resourceGroupName, routeFilterName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified rule from a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the create or update route filter rule operation.
            /// </param>
            public static RouteFilterRuleInner BeginCreateOrUpdate(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, RouteFilterRuleInner routeFilterRuleParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the create or update route filter rule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilterRuleInner> BeginCreateOrUpdateAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, RouteFilterRuleInner routeFilterRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the update route filter rule operation.
            /// </param>
            public static RouteFilterRuleInner BeginUpdate(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, PatchRouteFilterRuleInner routeFilterRuleParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a route in the specified route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='routeFilterName'>
            /// The name of the route filter.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the route filter rule.
            /// </param>
            /// <param name='routeFilterRuleParameters'>
            /// Parameters supplied to the update route filter rule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RouteFilterRuleInner> BeginUpdateAsync(this IRouteFilterRulesOperations operations, string resourceGroupName, string routeFilterName, string ruleName, PatchRouteFilterRuleInner routeFilterRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, routeFilterName, ruleName, routeFilterRuleParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all RouteFilterRules in a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RouteFilterRuleInner> ListByRouteFilterNext(this IRouteFilterRulesOperations operations, string nextPageLink)
            {
                return operations.ListByRouteFilterNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all RouteFilterRules in a route filter.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RouteFilterRuleInner>> ListByRouteFilterNextAsync(this IRouteFilterRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRouteFilterNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
