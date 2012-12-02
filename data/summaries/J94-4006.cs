Chester, Daniel (1980).
J80-2002
3. Combining Logical Form with Forests: A Case Study Previously, our logical form routines were interfaced with a one-parse-tree-at-a-time, top-down ATN parser (Harper 1990, 1992).
J92-4002
Use of an annotated shared-packed parse forest has the following benefits:. It provides a space savings by packing duplicate nodes into a single entry in the forest (Earley 1970; Seo and Simmons 1989; Tomita 1985), 652 Mary P.
J89-1002
However, for multiple logical representations to share the logical representation of a child node, that representation cannot be affected by the process of constructing the logical form for the parent node, an assumption that does not always hold (e.g., Harper 1990, 1992).
J92-4002
Marcus, Mitchell P., Hindle, Donald, and Fleck, Margaret (1983).
P83-1020
References Alshawi, Hiyan (1990).
J90-3001
Briscoe, Ted, and Carroll, John (1993).
J93-1002
Weischedel, Ralph (1989).
P89-1024
Before discussing the benefits of this approach, we describe the properties of a shared-packed parse forest (Seo and Simmons 1989; Tomita 1985, 1987).
J87-1004 J89-1002
Church, Kenneth, and Patil, Ramesh (1982).
J82-3004
Tomita, Masaru (1987).
J87-1004
The approach taken in this paper is to combine an all-path parsing algorithm (Chester 1980; Earley 1970; Kay 1980; Seo and Simmons 1989; Tomita 1985) with routines for generating logical representations in order to create a shared-packed parse forest annotated with the logical representations for the constituents in the forest (i.e., an annotated shared-packed parse forest).
J80-2002 J89-1002
Harper Storing Logical Form in a Shared-Packed Forest Unlike the ATN parser used by Harper (1990, 1992), the Tomita parser is a bottomup, all-path parsing algorithm that creates a parse forest by packing parse nodes together to save space and time.
J92-4002
Seo and Simmons (1989) have introduced syntactic graphs, which are constructed from shared-packed parse forests, to represent ambiguous parses for a sentence.
J89-1002
Schabes, Yves (1991).
P91-1014
Nederhof, Mark-Jan (1993).
E93-1036
Because of these benefits, we have designed a program to generate a sharedpacked parse forest annotated with the logical form developed by Harper (1990, 1992).
J92-4002
A slightly different alternative is to work with the highest preference choice only (Alshawi 1990; Briscoe and Carroll 1993).
J90-3001 J93-1002
As the number of PPs in a sentence increases, the number of possible parse trees and their corresponding representations grows as the Catalan numbers, C,, = \[2n~ 1 (Church \ n,' n+l and Patil 1982).
J82-3004
The conclusions we draw can also be applied to more efficient parsers (Earley 1970; Schabes 1991) that produce other logical representations (e.g., Alshawi and Crouch 1992; Hirst 1987; Weischedel 1989) in more compact forests (Nederhof 1993).
E93-1036 P89-1024 P91-1014 P92-1005
Alshawi, Hiyan, and Crouch, Richard (1992).
P92-1005
Description Theory (D-theory) (Marcus, Hindle, and Fleck 1983) uses the domination relation to specify structures of trees (rather than the parent relation), forming the basis of a class of deterministic parsers that build partial descriptions of trees rather than the trees themselves.
P83-1020
