import sys,time

class slow_print:
    def slow_print(text, delay=.05, break_after=None, break_time=.3, end='\n', flush=True):
        for i, char in enumerate(text):
            sys.stdout.write(char)
            if flush:
                sys.stdout.flush()
            time.sleep(delay)
            if break_after and (i + 1) % break_after == 0:
                time.sleep(break_time)
        sys.stdout.write(end)
        if flush:
            sys.stdout.flush()
