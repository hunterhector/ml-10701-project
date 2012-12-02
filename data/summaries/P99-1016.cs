the noun hierarchy The first stage in constructing our hierarchy is to build an unlabeled hierarchy of nouns using bottom-up clustering methods (see, e.g., Brown et al.(1992)). Nouns are clustered based on conjunction and appositive data collected from the Wall Street Journal corpus.
J92-4003
The idea here is that nouns in conjunctions or appositives tend to be semantically related, as discussed in Riloff and Shepherd (1997) and Roark and Charniak (1998).
P98-2182 W97-0313 W98-1115
Roark and Charniak (1998) built on that work by actually using conjunction and appositive data for noun clustering, as we do here.
P98-2182 W98-1115
Riloff and Shepherd (1997) suggested using conjunction and appositive data to cluster nouns; however, they approximated this data by just looking at the nearest NP on each side of a particular NP.
W97-0313
work Pereira et al.(1993) used clustering to build an unlabeled hierarchy of nouns.
P93-1024
Some of the data comes from the parsed files 2-21 of the Wall Street Journal Penn Treebank corpus (Marcus et al., 1993), and additional parsed text was obtained by parsing the 1987 Wall Street Journal text using the parser described in Charniak et al.(1998). From this parsed text, we identified all conjunctions of noun phrases (e.g., "executive vice-president and treasurer" or "scientific equipment, apparatus and disposables") and all appositives (e.g., "James H.
J93-2004 W98-1115
Both Hearst (1992) and Riloff and Shepherd (1997) use unparsed text.
C92-2082 W97-0313
Hearst (1992) introduced the idea of learning hypernym-hyponym relationships from text and gives several examples of patterns that can be used to detect these relationships including those used here, along with an algorithm for identifying new patterns.
C92-2082
Roark and Charniak (1998) report that for a handselected category, their algorithm generally produces 20% to 40% correct entries.
P98-2182 W98-1115
The "Hypernym 1/any" column can be used to compare results to Riloff and Shepherd (1997).
W97-0313
Additional hypernym data would also be helpful in this case, and should be easily obtainable by looking for other patterns in the text as suggested by Hearst (1992).
C92-2082
As suggested in Hearst (1992), we can find some hypernym data in the text by looking for conjunctions involving the word "other", as in "X, Y, and other Zs" (patterns 3 and 4 in Hearst).
C92-2082
Hearst (1992) gives an example of a potential hyponym-hypernym pair "broken bone/injury".
C92-2082
However, it would be interesting to see if parsing is necessary or if we can get equivalent or nearly-equivalent results doing some simpler text processing, as suggested in Ahlswede and Evens (1988).
P88-1027
Hearst. 1992.
C92-2082
