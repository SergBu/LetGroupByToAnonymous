// See https://aka.ms/new-console-template for more information
using LetGroupByToAnonymous;

var collectiveQuotasToCurrentOwnerHandledFromAnotherOwner = new List<TerminalRestriction>();

var myCollectiveRestrictionsByMemberIdGroupByRestrictionCreater = (from a in collectiveQuotasToCurrentOwnerHandledFromAnotherOwner
                                                                   let MemberId = a.RestrictionCreater.MemberId
                                                                   group a by MemberId into grouped
                                                                   select new
                                                                   {
                                                                       restrictionCreater = grouped.Key,
                                                                       VehicleCount = grouped.Sum(x => x.VehiclesCount)
                                                                   }).ToList();
