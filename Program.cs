using LeetCode;
using Newtonsoft.Json;
using System.Numerics;
using System.Text.Json.Serialization;

//ListNode l1 = new ListNode(1,
//    new ListNode(0,
//        new ListNode(0,
//            new ListNode(0,
//                new ListNode(0,
//                    new ListNode(0,
//                        new ListNode(0,
//                            new ListNode(0,
//                                new ListNode(0,
//                                    new ListNode(0,
//                                        new ListNode(0,
//                                            new ListNode(0,
//                                                new ListNode(0,
//                                                    new ListNode(0,
//                                                        new ListNode(0,
//                                                            new ListNode(0,
//                                                                new ListNode(0,
//                                                                    new ListNode(0,
//                                                                        new ListNode(0,
//                                                                            new ListNode(1)
//                                                                        )
//                                                                    )
//                                                                )
//                                                            )
//                                                        )
//                                                    )
//                                                )
//                                            )
//                                        )
//                                    )
//                                )
//                            )
//                        )
//                    )
//                )
//            )
//        )
//    )
//);

ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var result = AddTwoNumbersTast.AddTwoNumbers(
    l1,
    l2
);

// See https://aka.ms/new-console-template for more information
Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));

Console.WriteLine(result.GetNumber());
//Console.WriteLine(BigInteger.Parse(result.ToStringExtension()) + " " + result.ToString());