The approach adopted here is reminiscent of the line of research that employs the idea of character-based tagging for Chinese word segmentation and/or unknown word identification (Goh et al., 2003; Xue, 2003; Zhang et al., 2002).
P03-2039 W02-1817
Our hypothesis is that long words tend to have less fluidity than shorter words and their behavior is more predictable (Lu, 2005).
P05-2001
This component is based on the transformation-based learning (TBL) algorithm (Brill, 1995), where a simple first-order HMM tagger (Charniak et al., 1993) is used to produce an initial tagging of a character sequence.
J95-4004
The transformation-based tagger was implemented using fnTBL (Florian and Ngai, 2001).
N01-1006
The rule templates used are the same as the contextual rule templates Brill (1995) defined for the POS tagging task.
J95-4004
This segmenter is still in its early stage of development and is being developed as part of a larger Chinese unknown word resolution system that performs the identification, part of speech guessing, and sense guessing of Chinese unknown words (Lu, 2005).
P05-2001
The transformation-based error-driven learning algorithm is adopted as the backbone of the tagging component over other promising machine learning algorithms because, as Brill (1995) argued, it captures linguistic knowledge in a more explicit and direct fashion without compromising performance.
J95-4004
